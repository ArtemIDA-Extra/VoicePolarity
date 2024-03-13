namespace VoicePolarity
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Login_TB = new TextBox();
            Password_TB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Login_Button = new Button();
            TTS_TB = new RichTextBox();
            TTS_Label = new Label();
            OpenAI_BW = new System.ComponentModel.BackgroundWorker();
            TTSAccept_Button = new Button();
            TTSModel_CB = new ComboBox();
            TTSVoice_CB = new ComboBox();
            TTSModel_Label = new Label();
            TTSVoice_Label = new Label();
            TTSSpeed_CB = new ComboBox();
            TTSSpeed_Label = new Label();
            groupBox1 = new GroupBox();
            History_DG = new DataGridView();
            groupBox2 = new GroupBox();
            History_Empty_Label = new Label();
            ID = new DataGridViewTextBoxColumn();
            FileLocation = new DataGridViewTextBoxColumn();
            CopyPath = new DataGridViewButtonColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)History_DG).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // Login_TB
            // 
            Login_TB.Location = new Point(85, 22);
            Login_TB.Name = "Login_TB";
            Login_TB.Size = new Size(100, 23);
            Login_TB.TabIndex = 0;
            // 
            // Password_TB
            // 
            Password_TB.Location = new Point(85, 54);
            Password_TB.Name = "Password_TB";
            Password_TB.PasswordChar = '*';
            Password_TB.Size = new Size(100, 23);
            Password_TB.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 25);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 2;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 54);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // Login_Button
            // 
            Login_Button.Location = new Point(68, 83);
            Login_Button.Name = "Login_Button";
            Login_Button.Size = new Size(75, 23);
            Login_Button.TabIndex = 4;
            Login_Button.Text = "Sign In";
            Login_Button.UseVisualStyleBackColor = true;
            Login_Button.Click += Login_Button_Click;
            // 
            // TTS_TB
            // 
            TTS_TB.Enabled = false;
            TTS_TB.Location = new Point(9, 166);
            TTS_TB.MaxLength = 4096;
            TTS_TB.Name = "TTS_TB";
            TTS_TB.Size = new Size(572, 236);
            TTS_TB.TabIndex = 5;
            TTS_TB.Text = "";
            // 
            // TTS_Label
            // 
            TTS_Label.AutoSize = true;
            TTS_Label.Enabled = false;
            TTS_Label.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            TTS_Label.Location = new Point(222, 138);
            TTS_Label.Name = "TTS_Label";
            TTS_Label.Size = new Size(143, 25);
            TTS_Label.TabIndex = 6;
            TTS_Label.Text = "Text To Speech";
            // 
            // OpenAI_BW
            // 
            OpenAI_BW.DoWork += OpenAI_BW_DoWork;
            OpenAI_BW.RunWorkerCompleted += OpenAI_BW_RunWorkerCompleted;
            // 
            // TTSAccept_Button
            // 
            TTSAccept_Button.Enabled = false;
            TTSAccept_Button.Location = new Point(258, 408);
            TTSAccept_Button.Name = "TTSAccept_Button";
            TTSAccept_Button.Size = new Size(75, 23);
            TTSAccept_Button.TabIndex = 7;
            TTSAccept_Button.Text = "Voice it!";
            TTSAccept_Button.UseVisualStyleBackColor = true;
            TTSAccept_Button.Click += TTSAccept_Button_Click;
            // 
            // TTSModel_CB
            // 
            TTSModel_CB.Enabled = false;
            TTSModel_CB.FormattingEnabled = true;
            TTSModel_CB.Location = new Point(599, 190);
            TTSModel_CB.Name = "TTSModel_CB";
            TTSModel_CB.Size = new Size(121, 23);
            TTSModel_CB.TabIndex = 8;
            // 
            // TTSVoice_CB
            // 
            TTSVoice_CB.Enabled = false;
            TTSVoice_CB.FormattingEnabled = true;
            TTSVoice_CB.Location = new Point(599, 248);
            TTSVoice_CB.Name = "TTSVoice_CB";
            TTSVoice_CB.Size = new Size(121, 23);
            TTSVoice_CB.TabIndex = 9;
            // 
            // TTSModel_Label
            // 
            TTSModel_Label.AutoSize = true;
            TTSModel_Label.Enabled = false;
            TTSModel_Label.Location = new Point(637, 172);
            TTSModel_Label.Name = "TTSModel_Label";
            TTSModel_Label.Size = new Size(41, 15);
            TTSModel_Label.TabIndex = 11;
            TTSModel_Label.Text = "Model";
            // 
            // TTSVoice_Label
            // 
            TTSVoice_Label.AutoSize = true;
            TTSVoice_Label.Enabled = false;
            TTSVoice_Label.Location = new Point(643, 230);
            TTSVoice_Label.Name = "TTSVoice_Label";
            TTSVoice_Label.Size = new Size(35, 15);
            TTSVoice_Label.TabIndex = 12;
            TTSVoice_Label.Text = "Voice";
            // 
            // TTSSpeed_CB
            // 
            TTSSpeed_CB.Enabled = false;
            TTSSpeed_CB.FormattingEnabled = true;
            TTSSpeed_CB.Location = new Point(599, 308);
            TTSSpeed_CB.Name = "TTSSpeed_CB";
            TTSSpeed_CB.Size = new Size(121, 23);
            TTSSpeed_CB.TabIndex = 13;
            // 
            // TTSSpeed_Label
            // 
            TTSSpeed_Label.AutoSize = true;
            TTSSpeed_Label.Enabled = false;
            TTSSpeed_Label.Location = new Point(639, 290);
            TTSSpeed_Label.Name = "TTSSpeed_Label";
            TTSSpeed_Label.Size = new Size(39, 15);
            TTSSpeed_Label.TabIndex = 14;
            TTSSpeed_Label.Text = "Speed";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Password_TB);
            groupBox1.Controls.Add(Login_TB);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(Login_Button);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(201, 123);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "User";
            // 
            // History_DG
            // 
            History_DG.AllowUserToAddRows = false;
            History_DG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            History_DG.Columns.AddRange(new DataGridViewColumn[] { ID, FileLocation, CopyPath });
            History_DG.Location = new Point(6, 22);
            History_DG.Name = "History_DG";
            History_DG.ReadOnly = true;
            History_DG.RowHeadersVisible = false;
            History_DG.RowTemplate.Height = 25;
            History_DG.Size = new Size(476, 95);
            History_DG.TabIndex = 16;
            History_DG.Visible = false;
            History_DG.CellContentClick += History_DG_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(History_Empty_Label);
            groupBox2.Controls.Add(History_DG);
            groupBox2.Location = new Point(232, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(488, 123);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "History";
            // 
            // History_Empty_Label
            // 
            History_Empty_Label.AutoSize = true;
            History_Empty_Label.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            History_Empty_Label.Location = new Point(167, 63);
            History_Empty_Label.Name = "History_Empty_Label";
            History_Empty_Label.Size = new Size(156, 25);
            History_Empty_Label.TabIndex = 17;
            History_Empty_Label.Text = "History is Empty";
            History_Empty_Label.Visible = false;
            // 
            // ID
            // 
            ID.FillWeight = 50F;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 25;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 50;
            // 
            // FileLocation
            // 
            FileLocation.FillWeight = 375F;
            FileLocation.HeaderText = "FileLocation";
            FileLocation.MinimumWidth = 375;
            FileLocation.Name = "FileLocation";
            FileLocation.ReadOnly = true;
            FileLocation.Width = 375;
            // 
            // CopyPath
            // 
            CopyPath.FillWeight = 45F;
            CopyPath.HeaderText = "Copy";
            CopyPath.MinimumWidth = 45;
            CopyPath.Name = "CopyPath";
            CopyPath.ReadOnly = true;
            CopyPath.Resizable = DataGridViewTriState.True;
            CopyPath.SortMode = DataGridViewColumnSortMode.Automatic;
            CopyPath.Text = "Copy";
            CopyPath.UseColumnTextForButtonValue = true;
            CopyPath.Width = 45;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(TTSSpeed_Label);
            Controls.Add(TTSSpeed_CB);
            Controls.Add(TTSVoice_Label);
            Controls.Add(TTSModel_Label);
            Controls.Add(TTSVoice_CB);
            Controls.Add(TTSModel_CB);
            Controls.Add(TTSAccept_Button);
            Controls.Add(TTS_Label);
            Controls.Add(TTS_TB);
            Name = "MainForm";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)History_DG).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Login_TB;
        private TextBox Password_TB;
        private Label label1;
        private Label label2;
        private Button Login_Button;
        private RichTextBox TTS_TB;
        private Label TTS_Label;
        private System.ComponentModel.BackgroundWorker OpenAI_BW;
        private Button TTSAccept_Button;
        private ComboBox TTSModel_CB;
        private ComboBox TTSVoice_CB;
        private Label TTSModel_Label;
        private Label TTSVoice_Label;
        private ComboBox TTSSpeed_CB;
        private Label TTSSpeed_Label;
        private GroupBox groupBox1;
        private DataGridView History_DG;
        private GroupBox groupBox2;
        private Label History_Empty_Label;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn FileLocation;
        private DataGridViewButtonColumn CopyPath;
    }
}
