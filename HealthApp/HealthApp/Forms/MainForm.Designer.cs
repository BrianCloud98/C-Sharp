namespace HealthApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.weightNUD = new System.Windows.Forms.NumericUpDown();
            this.heightInNUD = new System.Windows.Forms.NumericUpDown();
            this.heightFtNUD = new System.Windows.Forms.NumericUpDown();
            this.DOBDayNUD = new System.Windows.Forms.NumericUpDown();
            this.DOBMonthNUD = new System.Windows.Forms.NumericUpDown();
            this.DOBYearNUD = new System.Windows.Forms.NumericUpDown();
            this.AllergyGB = new System.Windows.Forms.GroupBox();
            this.noRB = new System.Windows.Forms.RadioButton();
            this.yesRB = new System.Windows.Forms.RadioButton();
            this.LbsLabel = new System.Windows.Forms.Label();
            this.InchLabel = new System.Windows.Forms.Label();
            this.FtLabel = new System.Windows.Forms.Label();
            this.lNameTB = new System.Windows.Forms.TextBox();
            this.fNameTB = new System.Windows.Forms.TextBox();
            this.AllergyLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.RaceLabel = new System.Windows.Forms.Label();
            this.DOBLabel = new System.Windows.Forms.Label();
            this.LNameLabel = new System.Windows.Forms.Label();
            this.FNameLabel = new System.Windows.Forms.Label();
            this.TitleLogo = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.PCPCB = new System.Windows.Forms.ComboBox();
            this.PCPLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.genderCB = new System.Windows.Forms.ComboBox();
            this.ethnicityCB = new System.Windows.Forms.ComboBox();
            this.inputTextToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.exitButton = new System.Windows.Forms.Button();
            this.newClientPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.weightNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightInNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightFtNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOBDayNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOBMonthNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOBYearNUD)).BeginInit();
            this.AllergyGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // weightNUD
            // 
            this.weightNUD.Location = new System.Drawing.Point(159, 303);
            this.weightNUD.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.weightNUD.Name = "weightNUD";
            this.weightNUD.Size = new System.Drawing.Size(129, 20);
            this.weightNUD.TabIndex = 10;
            // 
            // heightInNUD
            // 
            this.heightInNUD.Location = new System.Drawing.Point(235, 262);
            this.heightInNUD.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.heightInNUD.Name = "heightInNUD";
            this.heightInNUD.Size = new System.Drawing.Size(61, 20);
            this.heightInNUD.TabIndex = 9;
            // 
            // heightFtNUD
            // 
            this.heightFtNUD.Location = new System.Drawing.Point(158, 261);
            this.heightFtNUD.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.heightFtNUD.Name = "heightFtNUD";
            this.heightFtNUD.Size = new System.Drawing.Size(58, 20);
            this.heightFtNUD.TabIndex = 8;
            // 
            // DOBDayNUD
            // 
            this.DOBDayNUD.Location = new System.Drawing.Point(205, 146);
            this.DOBDayNUD.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.DOBDayNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DOBDayNUD.Name = "DOBDayNUD";
            this.DOBDayNUD.Size = new System.Drawing.Size(41, 20);
            this.DOBDayNUD.TabIndex = 4;
            this.DOBDayNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DOBMonthNUD
            // 
            this.DOBMonthNUD.Location = new System.Drawing.Point(158, 146);
            this.DOBMonthNUD.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.DOBMonthNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DOBMonthNUD.Name = "DOBMonthNUD";
            this.DOBMonthNUD.Size = new System.Drawing.Size(41, 20);
            this.DOBMonthNUD.TabIndex = 3;
            this.DOBMonthNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DOBYearNUD
            // 
            this.DOBYearNUD.Location = new System.Drawing.Point(250, 146);
            this.DOBYearNUD.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.DOBYearNUD.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.DOBYearNUD.Name = "DOBYearNUD";
            this.DOBYearNUD.Size = new System.Drawing.Size(70, 20);
            this.DOBYearNUD.TabIndex = 5;
            this.DOBYearNUD.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // AllergyGB
            // 
            this.AllergyGB.Controls.Add(this.noRB);
            this.AllergyGB.Controls.Add(this.yesRB);
            this.AllergyGB.Location = new System.Drawing.Point(159, 329);
            this.AllergyGB.Name = "AllergyGB";
            this.AllergyGB.Size = new System.Drawing.Size(161, 42);
            this.AllergyGB.TabIndex = 84;
            this.AllergyGB.TabStop = false;
            // 
            // noRB
            // 
            this.noRB.AutoSize = true;
            this.noRB.ForeColor = System.Drawing.Color.Black;
            this.noRB.Location = new System.Drawing.Point(104, 15);
            this.noRB.Name = "noRB";
            this.noRB.Size = new System.Drawing.Size(39, 17);
            this.noRB.TabIndex = 12;
            this.noRB.TabStop = true;
            this.noRB.Text = "No";
            this.noRB.UseVisualStyleBackColor = true;
            // 
            // yesRB
            // 
            this.yesRB.AutoSize = true;
            this.yesRB.ForeColor = System.Drawing.Color.Black;
            this.yesRB.Location = new System.Drawing.Point(20, 15);
            this.yesRB.Name = "yesRB";
            this.yesRB.Size = new System.Drawing.Size(43, 17);
            this.yesRB.TabIndex = 11;
            this.yesRB.TabStop = true;
            this.yesRB.Text = "Yes";
            this.yesRB.UseVisualStyleBackColor = true;
            // 
            // LbsLabel
            // 
            this.LbsLabel.AutoSize = true;
            this.LbsLabel.Location = new System.Drawing.Point(290, 309);
            this.LbsLabel.Name = "LbsLabel";
            this.LbsLabel.Size = new System.Drawing.Size(27, 13);
            this.LbsLabel.TabIndex = 83;
            this.LbsLabel.Text = "Lbs.";
            // 
            // InchLabel
            // 
            this.InchLabel.AutoSize = true;
            this.InchLabel.Location = new System.Drawing.Point(297, 269);
            this.InchLabel.Name = "InchLabel";
            this.InchLabel.Size = new System.Drawing.Size(19, 13);
            this.InchLabel.TabIndex = 82;
            this.InchLabel.Text = "In.";
            // 
            // FtLabel
            // 
            this.FtLabel.AutoSize = true;
            this.FtLabel.Location = new System.Drawing.Point(215, 269);
            this.FtLabel.Name = "FtLabel";
            this.FtLabel.Size = new System.Drawing.Size(19, 13);
            this.FtLabel.TabIndex = 81;
            this.FtLabel.Text = "Ft.";
            // 
            // lNameTB
            // 
            this.lNameTB.Location = new System.Drawing.Point(159, 107);
            this.lNameTB.Name = "lNameTB";
            this.lNameTB.Size = new System.Drawing.Size(161, 20);
            this.lNameTB.TabIndex = 2;
            // 
            // fNameTB
            // 
            this.fNameTB.Location = new System.Drawing.Point(159, 72);
            this.fNameTB.Name = "fNameTB";
            this.fNameTB.Size = new System.Drawing.Size(161, 20);
            this.fNameTB.TabIndex = 1;
            // 
            // AllergyLabel
            // 
            this.AllergyLabel.AutoSize = true;
            this.AllergyLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllergyLabel.ForeColor = System.Drawing.Color.Black;
            this.AllergyLabel.Location = new System.Drawing.Point(19, 335);
            this.AllergyLabel.Name = "AllergyLabel";
            this.AllergyLabel.Size = new System.Drawing.Size(90, 28);
            this.AllergyLabel.TabIndex = 77;
            this.AllergyLabel.Text = "Allergy:";
            this.inputTextToolTip.SetToolTip(this.AllergyLabel, "Does Client Have a Known Allergy?");
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.ForeColor = System.Drawing.Color.Black;
            this.WeightLabel.Location = new System.Drawing.Point(20, 299);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(88, 28);
            this.WeightLabel.TabIndex = 76;
            this.WeightLabel.Text = "Weight:";
            this.inputTextToolTip.SetToolTip(this.WeightLabel, "Client\'s Weight in Pounds");
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightLabel.ForeColor = System.Drawing.Color.Black;
            this.HeightLabel.Location = new System.Drawing.Point(21, 255);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(86, 28);
            this.HeightLabel.TabIndex = 73;
            this.HeightLabel.Text = "Height:";
            this.inputTextToolTip.SetToolTip(this.HeightLabel, "Client\'s Height in Feet and Inches");
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLabel.ForeColor = System.Drawing.Color.Black;
            this.GenderLabel.Location = new System.Drawing.Point(19, 213);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(92, 28);
            this.GenderLabel.TabIndex = 71;
            this.GenderLabel.Text = "Gender:";
            this.inputTextToolTip.SetToolTip(this.GenderLabel, "Client\'s Gender");
            // 
            // RaceLabel
            // 
            this.RaceLabel.AutoSize = true;
            this.RaceLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaceLabel.ForeColor = System.Drawing.Color.Black;
            this.RaceLabel.Location = new System.Drawing.Point(19, 173);
            this.RaceLabel.Name = "RaceLabel";
            this.RaceLabel.Size = new System.Drawing.Size(108, 28);
            this.RaceLabel.TabIndex = 69;
            this.RaceLabel.Text = "Ethnicity:";
            this.inputTextToolTip.SetToolTip(this.RaceLabel, "Federally Recognized Race");
            // 
            // DOBLabel
            // 
            this.DOBLabel.AutoSize = true;
            this.DOBLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOBLabel.ForeColor = System.Drawing.Color.Black;
            this.DOBLabel.Location = new System.Drawing.Point(19, 136);
            this.DOBLabel.Name = "DOBLabel";
            this.DOBLabel.Size = new System.Drawing.Size(66, 28);
            this.DOBLabel.TabIndex = 68;
            this.DOBLabel.Text = "DOB:";
            this.inputTextToolTip.SetToolTip(this.DOBLabel, "Client\'s Date of Birth");
            // 
            // LNameLabel
            // 
            this.LNameLabel.AutoSize = true;
            this.LNameLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNameLabel.ForeColor = System.Drawing.Color.Black;
            this.LNameLabel.Location = new System.Drawing.Point(21, 99);
            this.LNameLabel.Name = "LNameLabel";
            this.LNameLabel.Size = new System.Drawing.Size(121, 28);
            this.LNameLabel.TabIndex = 66;
            this.LNameLabel.Text = "Last Name:";
            this.inputTextToolTip.SetToolTip(this.LNameLabel, "Client\'s Last Name");
            // 
            // FNameLabel
            // 
            this.FNameLabel.AutoSize = true;
            this.FNameLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNameLabel.ForeColor = System.Drawing.Color.Black;
            this.FNameLabel.Location = new System.Drawing.Point(19, 64);
            this.FNameLabel.Name = "FNameLabel";
            this.FNameLabel.Size = new System.Drawing.Size(124, 28);
            this.FNameLabel.TabIndex = 64;
            this.FNameLabel.Text = "First Name:";
            this.inputTextToolTip.SetToolTip(this.FNameLabel, "Client\'s First Name");
            // 
            // TitleLogo
            // 
            this.TitleLogo.AutoSize = true;
            this.TitleLogo.Font = new System.Drawing.Font("Palatino Linotype", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLogo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TitleLogo.Location = new System.Drawing.Point(16, 8);
            this.TitleLogo.Name = "TitleLogo";
            this.TitleLogo.Size = new System.Drawing.Size(324, 49);
            this.TitleLogo.TabIndex = 61;
            this.TitleLogo.Text = "Create New Client";
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.createButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.ForeColor = System.Drawing.Color.White;
            this.createButton.Location = new System.Drawing.Point(18, 422);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(313, 36);
            this.createButton.TabIndex = 89;
            this.createButton.Text = "Create";
            this.inputTextToolTip.SetToolTip(this.createButton, "Click to Add the New Client to Database");
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // PCPCB
            // 
            this.PCPCB.FormattingEnabled = true;
            this.PCPCB.Items.AddRange(new object[] {
            "Dr. Grant",
            "Dr. Smith",
            "Dr. Verugio",
            "Dr. Tweedy",
            "Dr. Merhson"});
            this.PCPCB.Location = new System.Drawing.Point(158, 379);
            this.PCPCB.Name = "PCPCB";
            this.PCPCB.Size = new System.Drawing.Size(162, 21);
            this.PCPCB.TabIndex = 13;
            // 
            // PCPLabel
            // 
            this.PCPLabel.AutoSize = true;
            this.PCPLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PCPLabel.ForeColor = System.Drawing.Color.Black;
            this.PCPLabel.Location = new System.Drawing.Point(20, 375);
            this.PCPLabel.Name = "PCPLabel";
            this.PCPLabel.Size = new System.Drawing.Size(58, 28);
            this.PCPLabel.TabIndex = 88;
            this.PCPLabel.Text = "PCP:";
            this.inputTextToolTip.SetToolTip(this.PCPLabel, "Primary Care Physician");
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.ForeColor = System.Drawing.Color.Black;
            this.yearLabel.Location = new System.Drawing.Point(247, 131);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(32, 13);
            this.yearLabel.TabIndex = 87;
            this.yearLabel.Text = "Year:";
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.ForeColor = System.Drawing.Color.Black;
            this.dayLabel.Location = new System.Drawing.Point(202, 131);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(29, 13);
            this.dayLabel.TabIndex = 86;
            this.dayLabel.Text = "Day:";
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.ForeColor = System.Drawing.Color.Black;
            this.monthLabel.Location = new System.Drawing.Point(156, 131);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(40, 13);
            this.monthLabel.TabIndex = 85;
            this.monthLabel.Text = "Month:";
            // 
            // genderCB
            // 
            this.genderCB.FormattingEnabled = true;
            this.genderCB.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.genderCB.Location = new System.Drawing.Point(158, 220);
            this.genderCB.Name = "genderCB";
            this.genderCB.Size = new System.Drawing.Size(162, 21);
            this.genderCB.TabIndex = 7;
            // 
            // ethnicityCB
            // 
            this.ethnicityCB.FormattingEnabled = true;
            this.ethnicityCB.Items.AddRange(new object[] {
            "Caucasian",
            "Hispanic",
            "Asian",
            "Native American",
            "African American",
            "Pacific Islander",
            "Other"});
            this.ethnicityCB.Location = new System.Drawing.Point(158, 180);
            this.ethnicityCB.Name = "ethnicityCB";
            this.ethnicityCB.Size = new System.Drawing.Size(162, 21);
            this.ethnicityCB.TabIndex = 6;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(18, 464);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(313, 36);
            this.exitButton.TabIndex = 91;
            this.exitButton.Text = "Exit";
            this.inputTextToolTip.SetToolTip(this.exitButton, "Click to Add the New Client to Database");
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // newClientPanel
            // 
            this.newClientPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.newClientPanel.ForeColor = System.Drawing.Color.Black;
            this.newClientPanel.Location = new System.Drawing.Point(18, 59);
            this.newClientPanel.Name = "newClientPanel";
            this.newClientPanel.Size = new System.Drawing.Size(313, 357);
            this.newClientPanel.TabIndex = 90;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(358, 514);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.weightNUD);
            this.Controls.Add(this.heightInNUD);
            this.Controls.Add(this.heightFtNUD);
            this.Controls.Add(this.DOBDayNUD);
            this.Controls.Add(this.DOBMonthNUD);
            this.Controls.Add(this.DOBYearNUD);
            this.Controls.Add(this.AllergyGB);
            this.Controls.Add(this.LbsLabel);
            this.Controls.Add(this.InchLabel);
            this.Controls.Add(this.FtLabel);
            this.Controls.Add(this.lNameTB);
            this.Controls.Add(this.fNameTB);
            this.Controls.Add(this.AllergyLabel);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.RaceLabel);
            this.Controls.Add(this.DOBLabel);
            this.Controls.Add(this.LNameLabel);
            this.Controls.Add(this.FNameLabel);
            this.Controls.Add(this.TitleLogo);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.PCPCB);
            this.Controls.Add(this.PCPLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.genderCB);
            this.Controls.Add(this.ethnicityCB);
            this.Controls.Add(this.newClientPanel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Saint Augustine Health System";
            ((System.ComponentModel.ISupportInitialize)(this.weightNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightInNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightFtNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOBDayNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOBMonthNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOBYearNUD)).EndInit();
            this.AllergyGB.ResumeLayout(false);
            this.AllergyGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown weightNUD;
        private System.Windows.Forms.NumericUpDown heightInNUD;
        private System.Windows.Forms.NumericUpDown heightFtNUD;
        private System.Windows.Forms.NumericUpDown DOBDayNUD;
        private System.Windows.Forms.NumericUpDown DOBMonthNUD;
        private System.Windows.Forms.NumericUpDown DOBYearNUD;
        private System.Windows.Forms.GroupBox AllergyGB;
        private System.Windows.Forms.RadioButton noRB;
        private System.Windows.Forms.RadioButton yesRB;
        private System.Windows.Forms.Label LbsLabel;
        private System.Windows.Forms.Label InchLabel;
        private System.Windows.Forms.Label FtLabel;
        private System.Windows.Forms.TextBox lNameTB;
        private System.Windows.Forms.TextBox fNameTB;
        private System.Windows.Forms.Label AllergyLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Label RaceLabel;
        private System.Windows.Forms.Label DOBLabel;
        private System.Windows.Forms.Label LNameLabel;
        private System.Windows.Forms.Label FNameLabel;
        private System.Windows.Forms.Label TitleLogo;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.ComboBox PCPCB;
        private System.Windows.Forms.Label PCPLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.ComboBox genderCB;
        private System.Windows.Forms.ComboBox ethnicityCB;
        private System.Windows.Forms.ToolTip inputTextToolTip;
        private System.Windows.Forms.Panel newClientPanel;
        private System.Windows.Forms.Button exitButton;
    }
}