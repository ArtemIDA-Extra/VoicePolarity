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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Play = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CopyPath = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.History_Empty_Label = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.History_DG)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login_TB
            // 
            this.Login_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Login_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Login_TB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Login_TB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Login_TB.Location = new System.Drawing.Point(85, 22);
            this.Login_TB.Name = "Login_TB";
            this.Login_TB.Size = new System.Drawing.Size(100, 23);
            this.Login_TB.TabIndex = 0;
            // 
            // Password_TB
            // 
            this.Password_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Password_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password_TB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Password_TB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Password_TB.Location = new System.Drawing.Point(85, 54);
            this.Password_TB.Name = "Password_TB";
            this.Password_TB.PasswordChar = '*';
            this.Password_TB.Size = new System.Drawing.Size(100, 23);
            this.Password_TB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(35, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // Login_Button
            // 
            this.Login_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Login_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Login_Button.Font = new System.Drawing.Font("Comfortaa SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Login_Button.Location = new System.Drawing.Point(65, 83);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(75, 27);
            this.Login_Button.TabIndex = 4;
            this.Login_Button.Text = "Sign In";
            this.Login_Button.UseVisualStyleBackColor = false;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // TTS_TB
            // 
            this.TTS_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TTS_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TTS_TB.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TTS_TB.ForeColor = System.Drawing.SystemColors.ButtonFace;
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
            this.TTS_Label.Font = new System.Drawing.Font("Comfortaa Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TTS_Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TTS_Label.Location = new System.Drawing.Point(219, 132);
            this.TTS_Label.Name = "TTS_Label";
            this.TTS_Label.Size = new System.Drawing.Size(177, 34);
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
            this.TTSAccept_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TTSAccept_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TTSAccept_Button.Font = new System.Drawing.Font("Comfortaa SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TTSAccept_Button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TTSAccept_Button.Location = new System.Drawing.Point(258, 408);
            this.TTSAccept_Button.Name = "TTSAccept_Button";
            this.TTSAccept_Button.Size = new System.Drawing.Size(75, 30);
            this.TTSAccept_Button.TabIndex = 7;
            this.TTSAccept_Button.Text = "Voice it!";
            this.TTSAccept_Button.UseVisualStyleBackColor = false;
            this.TTSAccept_Button.Click += new System.EventHandler(this.TTSAccept_Button_Click);
            // 
            // TTSModel_CB
            // 
            this.TTSModel_CB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TTSModel_CB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TTSModel_CB.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TTSModel_CB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TTSModel_CB.FormattingEnabled = true;
            this.TTSModel_CB.Location = new System.Drawing.Point(599, 190);
            this.TTSModel_CB.Name = "TTSModel_CB";
            this.TTSModel_CB.Size = new System.Drawing.Size(121, 27);
            this.TTSModel_CB.TabIndex = 8;
            // 
            // TTSVoice_CB
            // 
            this.TTSVoice_CB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TTSVoice_CB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TTSVoice_CB.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TTSVoice_CB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TTSVoice_CB.FormattingEnabled = true;
            this.TTSVoice_CB.Location = new System.Drawing.Point(599, 248);
            this.TTSVoice_CB.Name = "TTSVoice_CB";
            this.TTSVoice_CB.Size = new System.Drawing.Size(121, 27);
            this.TTSVoice_CB.TabIndex = 9;
            // 
            // TTSModel_Label
            // 
            this.TTSModel_Label.AutoSize = true;
            this.TTSModel_Label.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TTSModel_Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TTSModel_Label.Location = new System.Drawing.Point(635, 166);
            this.TTSModel_Label.Name = "TTSModel_Label";
            this.TTSModel_Label.Size = new System.Drawing.Size(53, 21);
            this.TTSModel_Label.TabIndex = 11;
            this.TTSModel_Label.Text = "Model";
            // 
            // TTSVoice_Label
            // 
            this.TTSVoice_Label.AutoSize = true;
            this.TTSVoice_Label.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TTSVoice_Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TTSVoice_Label.Location = new System.Drawing.Point(635, 224);
            this.TTSVoice_Label.Name = "TTSVoice_Label";
            this.TTSVoice_Label.Size = new System.Drawing.Size(47, 21);
            this.TTSVoice_Label.TabIndex = 12;
            this.TTSVoice_Label.Text = "Voice";
            // 
            // TTSSpeed_CB
            // 
            this.TTSSpeed_CB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TTSSpeed_CB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TTSSpeed_CB.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TTSSpeed_CB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TTSSpeed_CB.FormattingEnabled = true;
            this.TTSSpeed_CB.Location = new System.Drawing.Point(599, 308);
            this.TTSSpeed_CB.Name = "TTSSpeed_CB";
            this.TTSSpeed_CB.Size = new System.Drawing.Size(121, 27);
            this.TTSSpeed_CB.TabIndex = 13;
            // 
            // TTSSpeed_Label
            // 
            this.TTSSpeed_Label.AutoSize = true;
            this.TTSSpeed_Label.Font = new System.Drawing.Font("Comfortaa SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TTSSpeed_Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TTSSpeed_Label.Location = new System.Drawing.Point(633, 284);
            this.TTSSpeed_Label.Name = "TTSSpeed_Label";
            this.TTSSpeed_Label.Size = new System.Drawing.Size(53, 21);
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
            this.groupBox1.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.History_DG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.History_DG.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.History_DG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.History_DG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.History_DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.History_DG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FileLocation,
            this.Play,
            this.CopyPath});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.History_DG.DefaultCellStyle = dataGridViewCellStyle7;
            this.History_DG.EnableHeadersVisualStyles = false;
            this.History_DG.Location = new System.Drawing.Point(6, 22);
            this.History_DG.Name = "History_DG";
            this.History_DG.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.History_DG.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.History_DG.RowHeadersVisible = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.History_DG.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.History_DG.RowTemplate.Height = 25;
            this.History_DG.Size = new System.Drawing.Size(535, 95);
            this.History_DG.TabIndex = 16;
            this.History_DG.Visible = false;
            this.History_DG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.History_DG_CellContentClick);
            // 
            // ID
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comfortaa", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ID.DefaultCellStyle = dataGridViewCellStyle3;
            this.ID.FillWeight = 50F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 25;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // FileLocation
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comfortaa", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FileLocation.DefaultCellStyle = dataGridViewCellStyle4;
            this.FileLocation.FillWeight = 375F;
            this.FileLocation.HeaderText = "FileLocation";
            this.FileLocation.MinimumWidth = 100;
            this.FileLocation.Name = "FileLocation";
            this.FileLocation.ReadOnly = true;
            this.FileLocation.Width = 375;
            // 
            // Play
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Comfortaa", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Play.DefaultCellStyle = dataGridViewCellStyle5;
            this.Play.FillWeight = 45F;
            this.Play.HeaderText = "Play";
            this.Play.MinimumWidth = 45;
            this.Play.Name = "Play";
            this.Play.ReadOnly = true;
            this.Play.Text = "Play";
            this.Play.UseColumnTextForButtonValue = true;
            this.Play.Width = 45;
            // 
            // CopyPath
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Comfortaa", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CopyPath.DefaultCellStyle = dataGridViewCellStyle6;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.History_Empty_Label);
            this.groupBox2.Controls.Add(this.History_DG);
            this.groupBox2.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(232, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(547, 123);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "History";
            // 
            // History_Empty_Label
            // 
            this.History_Empty_Label.AutoSize = true;
            this.History_Empty_Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.History_Empty_Label.Font = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.History_Empty_Label.Location = new System.Drawing.Point(167, 63);
            this.History_Empty_Label.Name = "History_Empty_Label";
            this.History_Empty_Label.Size = new System.Drawing.Size(176, 30);
            this.History_Empty_Label.TabIndex = 17;
            this.History_Empty_Label.Text = "History is Empty";
            this.History_Empty_Label.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(791, 450);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Voice Polarity";
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
        private DataGridViewButtonColumn Play;
        private DataGridViewButtonColumn CopyPath;
    }
}
