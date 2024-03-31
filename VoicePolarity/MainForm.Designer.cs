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
            this.Login_TB = new System.Windows.Forms.TextBox();
            this.Password_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Login_Button = new System.Windows.Forms.Button();
            this.TTS_TB = new System.Windows.Forms.RichTextBox();
            this.TTS_Label = new System.Windows.Forms.Label();
            this.OpenAI_BW = new System.ComponentModel.BackgroundWorker();
            this.TTSAccept_Button = new System.Windows.Forms.Button();
            this.TTSModel_CB = new System.Windows.Forms.ComboBox();
            this.TTSVoice_CB = new System.Windows.Forms.ComboBox();
            this.TTSModel_Label = new System.Windows.Forms.Label();
            this.TTSVoice_Label = new System.Windows.Forms.Label();
            this.TTSSpeed_CB = new System.Windows.Forms.ComboBox();
            this.TTSSpeed_Label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.History_DG = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.History_Empty_Label = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CopyPath = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.History_DG)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login_TB
            // 
            this.Login_TB.Location = new System.Drawing.Point(85, 22);
            this.Login_TB.Name = "Login_TB";
            this.Login_TB.Size = new System.Drawing.Size(100, 23);
            this.Login_TB.TabIndex = 0;
            // 
            // Password_TB
            // 
            this.Password_TB.Location = new System.Drawing.Point(85, 54);
            this.Password_TB.Name = "Password_TB";
            this.Password_TB.PasswordChar = '*';
            this.Password_TB.Size = new System.Drawing.Size(100, 23);
            this.Password_TB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // Login_Button
            // 
            this.Login_Button.Location = new System.Drawing.Point(68, 83);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(75, 23);
            this.Login_Button.TabIndex = 4;
            this.Login_Button.Text = "Sign In";
            this.Login_Button.UseVisualStyleBackColor = true;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // TTS_TB
            // 
            this.TTS_TB.Enabled = false;
            this.TTS_TB.Location = new System.Drawing.Point(9, 166);
            this.TTS_TB.MaxLength = 4096;
            this.TTS_TB.Name = "TTS_TB";
            this.TTS_TB.Size = new System.Drawing.Size(572, 236);
            this.TTS_TB.TabIndex = 5;
            this.TTS_TB.Text = "";
            // 
            // TTS_Label
            // 
            this.TTS_Label.AutoSize = true;
            this.TTS_Label.Enabled = false;
            this.TTS_Label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TTS_Label.Location = new System.Drawing.Point(222, 138);
            this.TTS_Label.Name = "TTS_Label";
            this.TTS_Label.Size = new System.Drawing.Size(143, 25);
            this.TTS_Label.TabIndex = 6;
            this.TTS_Label.Text = "Text To Speech";
            // 
            // OpenAI_BW
            // 
            this.OpenAI_BW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.OpenAI_BW_DoWork);
            this.OpenAI_BW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.OpenAI_BW_RunWorkerCompleted);
            // 
            // TTSAccept_Button
            // 
            this.TTSAccept_Button.Enabled = false;
            this.TTSAccept_Button.Location = new System.Drawing.Point(258, 408);
            this.TTSAccept_Button.Name = "TTSAccept_Button";
            this.TTSAccept_Button.Size = new System.Drawing.Size(75, 23);
            this.TTSAccept_Button.TabIndex = 7;
            this.TTSAccept_Button.Text = "Voice it!";
            this.TTSAccept_Button.UseVisualStyleBackColor = true;
            this.TTSAccept_Button.Click += new System.EventHandler(this.TTSAccept_Button_Click);
            // 
            // TTSModel_CB
            // 
            this.TTSModel_CB.Enabled = false;
            this.TTSModel_CB.FormattingEnabled = true;
            this.TTSModel_CB.Location = new System.Drawing.Point(599, 190);
            this.TTSModel_CB.Name = "TTSModel_CB";
            this.TTSModel_CB.Size = new System.Drawing.Size(121, 23);
            this.TTSModel_CB.TabIndex = 8;
            // 
            // TTSVoice_CB
            // 
            this.TTSVoice_CB.Enabled = false;
            this.TTSVoice_CB.FormattingEnabled = true;
            this.TTSVoice_CB.Location = new System.Drawing.Point(599, 248);
            this.TTSVoice_CB.Name = "TTSVoice_CB";
            this.TTSVoice_CB.Size = new System.Drawing.Size(121, 23);
            this.TTSVoice_CB.TabIndex = 9;
            // 
            // TTSModel_Label
            // 
            this.TTSModel_Label.AutoSize = true;
            this.TTSModel_Label.Enabled = false;
            this.TTSModel_Label.Location = new System.Drawing.Point(637, 172);
            this.TTSModel_Label.Name = "TTSModel_Label";
            this.TTSModel_Label.Size = new System.Drawing.Size(41, 15);
            this.TTSModel_Label.TabIndex = 11;
            this.TTSModel_Label.Text = "Model";
            // 
            // TTSVoice_Label
            // 
            this.TTSVoice_Label.AutoSize = true;
            this.TTSVoice_Label.Enabled = false;
            this.TTSVoice_Label.Location = new System.Drawing.Point(643, 230);
            this.TTSVoice_Label.Name = "TTSVoice_Label";
            this.TTSVoice_Label.Size = new System.Drawing.Size(35, 15);
            this.TTSVoice_Label.TabIndex = 12;
            this.TTSVoice_Label.Text = "Voice";
            // 
            // TTSSpeed_CB
            // 
            this.TTSSpeed_CB.Enabled = false;
            this.TTSSpeed_CB.FormattingEnabled = true;
            this.TTSSpeed_CB.Location = new System.Drawing.Point(599, 308);
            this.TTSSpeed_CB.Name = "TTSSpeed_CB";
            this.TTSSpeed_CB.Size = new System.Drawing.Size(121, 23);
            this.TTSSpeed_CB.TabIndex = 13;
            // 
            // TTSSpeed_Label
            // 
            this.TTSSpeed_Label.AutoSize = true;
            this.TTSSpeed_Label.Enabled = false;
            this.TTSSpeed_Label.Location = new System.Drawing.Point(639, 290);
            this.TTSSpeed_Label.Name = "TTSSpeed_Label";
            this.TTSSpeed_Label.Size = new System.Drawing.Size(39, 15);
            this.TTSSpeed_Label.TabIndex = 14;
            this.TTSSpeed_Label.Text = "Speed";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Password_TB);
            this.groupBox1.Controls.Add(this.Login_TB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Login_Button);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 123);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User";
            // 
            // History_DG
            // 
            this.History_DG.AllowUserToAddRows = false;
            this.History_DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.History_DG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FileLocation,
            this.CopyPath});
            this.History_DG.Location = new System.Drawing.Point(6, 22);
            this.History_DG.Name = "History_DG";
            this.History_DG.ReadOnly = true;
            this.History_DG.RowHeadersVisible = false;
            this.History_DG.RowTemplate.Height = 25;
            this.History_DG.Size = new System.Drawing.Size(476, 95);
            this.History_DG.TabIndex = 16;
            this.History_DG.Visible = false;
            this.History_DG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.History_DG_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.History_Empty_Label);
            this.groupBox2.Controls.Add(this.History_DG);
            this.groupBox2.Location = new System.Drawing.Point(232, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 123);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "History";
            // 
            // History_Empty_Label
            // 
            this.History_Empty_Label.AutoSize = true;
            this.History_Empty_Label.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.History_Empty_Label.Location = new System.Drawing.Point(167, 63);
            this.History_Empty_Label.Name = "History_Empty_Label";
            this.History_Empty_Label.Size = new System.Drawing.Size(156, 25);
            this.History_Empty_Label.TabIndex = 17;
            this.History_Empty_Label.Text = "History is Empty";
            this.History_Empty_Label.Visible = false;
            // 
            // ID
            // 
            this.ID.FillWeight = 50F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 25;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // FileLocation
            // 
            this.FileLocation.FillWeight = 375F;
            this.FileLocation.HeaderText = "FileLocation";
            this.FileLocation.MinimumWidth = 100;
            this.FileLocation.Name = "FileLocation";
            this.FileLocation.ReadOnly = true;
            this.FileLocation.Width = 375;
            // 
            // CopyPath
            // 
            this.CopyPath.FillWeight = 45F;
            this.CopyPath.HeaderText = "Copy";
            this.CopyPath.MinimumWidth = 45;
            this.CopyPath.Name = "CopyPath";
            this.CopyPath.ReadOnly = true;
            this.CopyPath.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CopyPath.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CopyPath.Text = "Copy";
            this.CopyPath.UseColumnTextForButtonValue = true;
            this.CopyPath.Width = 45;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TTSSpeed_Label);
            this.Controls.Add(this.TTSSpeed_CB);
            this.Controls.Add(this.TTSVoice_Label);
            this.Controls.Add(this.TTSModel_Label);
            this.Controls.Add(this.TTSVoice_CB);
            this.Controls.Add(this.TTSModel_CB);
            this.Controls.Add(this.TTSAccept_Button);
            this.Controls.Add(this.TTS_Label);
            this.Controls.Add(this.TTS_TB);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.History_DG)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
