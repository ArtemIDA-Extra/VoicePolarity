
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using NAudio;
using NAudio.Wave;
using NAudio.Dmo;

namespace VoicePolarity
{
    public partial class MainForm : Form
    {
        VoicePolarityDBContext dbContext;
        User ActiveUser = null;

        private struct TTSRequestArgs
        {
            public string TextToSpeech;
            public TTSModel Model;
            public TTSVoice Voice;
            public float Speed;
        }

        public MainForm(VoicePolarityDBContext db)
        {
            dbContext = db;

            //Test();
            InitializeComponent();

            //Login_Button.Click += Login_Button_Click;
            //History_DG.CellContentClick += History_DG_CellContentClick;
            //TTSAccept_Button.Click += TTSAccept_Button_Click;
            //OpenAI_BW.DoWork += OpenAI_BW_DoWork;
            //OpenAI_BW.RunWorkerCompleted += OpenAI_BW_RunWorkerCompleted;


            ShowHistorySection(false);
            ShowTTSSection(false);
            InitTTSComboBoxes();
        }

        private void InitTTSComboBoxes()
        {
            TTSModel_CB.Items.Add("TTS_1_HD");
            TTSModel_CB.Items.Add("TTS_1");
            TTSModel_CB.SelectedIndex = 0;

            TTSVoice_CB.Items.Add("Alloy");
            TTSVoice_CB.Items.Add("Echo");
            TTSVoice_CB.Items.Add("Fable");
            TTSVoice_CB.Items.Add("Onyx");
            TTSVoice_CB.Items.Add("Nova");
            TTSVoice_CB.Items.Add("Shimmer");
            TTSVoice_CB.SelectedIndex = 0;

            TTSSpeed_CB.Items.Add("0.25");
            TTSSpeed_CB.Items.Add("0.5");
            TTSSpeed_CB.Items.Add("0.75");
            TTSSpeed_CB.Items.Add("1");
            TTSSpeed_CB.Items.Add("2");
            TTSSpeed_CB.Items.Add("3");
            TTSSpeed_CB.Items.Add("4");
            TTSSpeed_CB.SelectedIndex = 0;
        }
        private void Login_Button_Click(object sender, EventArgs e)
        {
            if (Login_TB.Text != "")
            {
                if (Password_TB.Text != "")
                {
                    User? foundedUser = dbContext.Users.Include(h => h.History)
                        .Where(u => u.Login == Login_TB.Text && u.Password == Password_TB.Text)
                        .FirstOrDefault();
                    if (foundedUser != null)
                    {
                        ActiveUser = foundedUser;
                        UpdateHistory();
                        MessageBox.Show("Login successful!");
                        ShowHistorySection(true);
                        ShowTTSSection(true);
                    }
                    else MessageBox.Show("The login or password is incorrect. Try again.");
                }
                else MessageBox.Show("Password not entered!");
            }
            else MessageBox.Show("Login not entered!");
        }

        private void UpdateHistory()
        {
            if (ActiveUser.History.Count == 0)
            {
                History_Empty_Label.Visible = true;
                History_DG.Visible = false;
            }
            else
            {
                History_Empty_Label.Visible = false;

                History_DG.Rows.Clear();
                foreach (var history in ActiveUser.History)
                {
                    Button copyBtn = new Button()
                    {
                        Text = "Copy",
                    };
                    History_DG.Rows.Add(
                        history.ID,
                        history.FilePath,
                        copyBtn);
                }

                History_DG.Visible = true;
            }
        }

        private void History_DG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (History_DG[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell && e.ColumnIndex == 3)
                Clipboard.SetText(History_DG.Rows[e.RowIndex].Cells[1].Value.ToString());
            if (History_DG[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell && e.ColumnIndex == 2)
                PlayMP3(History_DG.Rows[e.RowIndex].Cells[1].Value.ToString());
        }

        private void ShowHistorySection(bool enable)
        {
            groupBox2.Visible = enable;
        }
        private void ShowTTSSection(bool enable)
        {
            TTSModel_Label.Visible = enable;
            TTSModel_CB.Visible = enable;
            TTSVoice_Label.Visible = enable;
            TTSVoice_CB.Visible = enable;
            TTSSpeed_Label.Visible = enable;
            TTSSpeed_CB.Visible = enable;
            TTS_Label.Visible = enable;
            TTS_TB.Visible = enable;
            TTSAccept_Button.Visible = enable;
        }

        void Test()
        {
            User user = new User() { Login = "artem", Password = "123" };
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
        }
        private void TTSAccept_Button_Click(object sender, EventArgs e)
        {
            if (TTS_TB.Text != "")
            {
                var Args = new TTSRequestArgs
                {
                    TextToSpeech = TTS_TB.Text,
                    Model = (TTSModel)TTSModel_CB.SelectedIndex,
                    Voice = (TTSVoice)TTSVoice_CB.SelectedIndex,
                    Speed = float.Parse(TTSSpeed_CB.SelectedItem.ToString(), CultureInfo.InvariantCulture.NumberFormat)
                };
                OpenAI_BW.RunWorkerAsync(Args);
            }
            else MessageBox.Show("Text to speech not entered!");
        }

        private void OpenAI_BW_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (!Directory.Exists(AppContext.BaseDirectory + "Samples"))
                Directory.CreateDirectory(AppContext.BaseDirectory + "Samples");
            if (!Directory.Exists(AppContext.BaseDirectory + "Samples/" + ActiveUser.Login))
                Directory.CreateDirectory(AppContext.BaseDirectory + "Samples/" + ActiveUser.Login);

            TTSRequestArgs args = (TTSRequestArgs)e.Argument;

            OpenAIWrapper OpenAI_TTS = new OpenAIWrapper();
            Task<byte[]> TTSRequestTask = OpenAI_TTS.RequestTextToSpeech(args.TextToSpeech, args.Model, args.Voice, args.Speed);
            TTSRequestTask.Wait();
            byte[] result = TTSRequestTask.Result;
            string savePath = AppContext.BaseDirectory + $"Samples\\{ActiveUser.Login}\\" + $"{ActiveUser.Login}_{ActiveUser.ID}_{DateTime.Now.Ticks}.mp3";
            File.WriteAllBytes(savePath, result);
            dbContext.Histories.Add(new History
            {
                User = ActiveUser,
                FilePath = savePath,
                TTSText = args.TextToSpeech
            });
            dbContext.SaveChanges();
        }

        private void OpenAI_BW_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            UpdateHistory();
            MessageBox.Show("Sample generation completed.");
        }

        private static void PlayMP3(string filePath)
        {
            if (File.Exists(filePath))
            {
                MediaFoundationReader reader = new MediaFoundationReader(filePath);
                var waveOut = new WaveOut();
                waveOut.Init(reader);
                waveOut.Play();
            }
            else
                throw new Exception($"File on path [{filePath}] not found!");
        }
    }

}
