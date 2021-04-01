namespace HealthApp
{
    partial class DisplayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayForm));
            this.label1 = new System.Windows.Forms.Label();
            this.fNameLB = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ageTB = new System.Windows.Forms.TextBox();
            this.bmiCategoryTB = new System.Windows.Forms.TextBox();
            this.bmiTB = new System.Windows.Forms.TextBox();
            this.pcpTB = new System.Windows.Forms.TextBox();
            this.allergiesTB = new System.Windows.Forms.TextBox();
            this.weightTB = new System.Windows.Forms.TextBox();
            this.heightTB = new System.Windows.Forms.TextBox();
            this.genderTB = new System.Windows.Forms.TextBox();
            this.ethnicityTB = new System.Windows.Forms.TextBox();
            this.dobTB = new System.Windows.Forms.TextBox();
            this.lNameTB = new System.Windows.Forms.TextBox();
            this.bmiCategoryLB = new System.Windows.Forms.Label();
            this.fNameTB = new System.Windows.Forms.TextBox();
            this.ageLB = new System.Windows.Forms.Label();
            this.bmiLB = new System.Windows.Forms.Label();
            this.pcpLB = new System.Windows.Forms.Label();
            this.lNameLB = new System.Windows.Forms.Label();
            this.dobLB = new System.Windows.Forms.Label();
            this.ethnicityLB = new System.Windows.Forms.Label();
            this.genderLB = new System.Windows.Forms.Label();
            this.heightLB = new System.Windows.Forms.Label();
            this.weightLB = new System.Windows.Forms.Label();
            this.allergiesLB = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(13, -6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 49);
            this.label1.TabIndex = 92;
            this.label1.Text = "Display Client Info";
            // 
            // fNameLB
            // 
            this.fNameLB.AutoSize = true;
            this.fNameLB.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameLB.ForeColor = System.Drawing.Color.Black;
            this.fNameLB.Location = new System.Drawing.Point(11, 3);
            this.fNameLB.Name = "fNameLB";
            this.fNameLB.Size = new System.Drawing.Size(124, 28);
            this.fNameLB.TabIndex = 92;
            this.fNameLB.Text = "First Name:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.ageTB);
            this.panel1.Controls.Add(this.bmiCategoryTB);
            this.panel1.Controls.Add(this.bmiTB);
            this.panel1.Controls.Add(this.pcpTB);
            this.panel1.Controls.Add(this.fNameLB);
            this.panel1.Controls.Add(this.pcpLB);
            this.panel1.Controls.Add(this.genderLB);
            this.panel1.Controls.Add(this.allergiesTB);
            this.panel1.Controls.Add(this.weightTB);
            this.panel1.Controls.Add(this.ethnicityLB);
            this.panel1.Controls.Add(this.heightTB);
            this.panel1.Controls.Add(this.dobLB);
            this.panel1.Controls.Add(this.lNameLB);
            this.panel1.Controls.Add(this.genderTB);
            this.panel1.Controls.Add(this.ethnicityTB);
            this.panel1.Controls.Add(this.dobTB);
            this.panel1.Controls.Add(this.lNameTB);
            this.panel1.Controls.Add(this.bmiCategoryLB);
            this.panel1.Controls.Add(this.fNameTB);
            this.panel1.Controls.Add(this.ageLB);
            this.panel1.Controls.Add(this.bmiLB);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(22, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 408);
            this.panel1.TabIndex = 101;
            // 
            // ageTB
            // 
            this.ageTB.Location = new System.Drawing.Point(240, 82);
            this.ageTB.Name = "ageTB";
            this.ageTB.ReadOnly = true;
            this.ageTB.Size = new System.Drawing.Size(60, 20);
            this.ageTB.TabIndex = 113;
            // 
            // bmiCategoryTB
            // 
            this.bmiCategoryTB.Location = new System.Drawing.Point(152, 377);
            this.bmiCategoryTB.Name = "bmiCategoryTB";
            this.bmiCategoryTB.ReadOnly = true;
            this.bmiCategoryTB.Size = new System.Drawing.Size(147, 20);
            this.bmiCategoryTB.TabIndex = 112;
            // 
            // bmiTB
            // 
            this.bmiTB.Location = new System.Drawing.Point(25, 377);
            this.bmiTB.Name = "bmiTB";
            this.bmiTB.ReadOnly = true;
            this.bmiTB.Size = new System.Drawing.Size(94, 20);
            this.bmiTB.TabIndex = 111;
            // 
            // pcpTB
            // 
            this.pcpTB.Location = new System.Drawing.Point(137, 324);
            this.pcpTB.Name = "pcpTB";
            this.pcpTB.ReadOnly = true;
            this.pcpTB.Size = new System.Drawing.Size(162, 20);
            this.pcpTB.TabIndex = 110;
            // 
            // allergiesTB
            // 
            this.allergiesTB.Location = new System.Drawing.Point(137, 284);
            this.allergiesTB.Name = "allergiesTB";
            this.allergiesTB.ReadOnly = true;
            this.allergiesTB.Size = new System.Drawing.Size(162, 20);
            this.allergiesTB.TabIndex = 109;
            // 
            // weightTB
            // 
            this.weightTB.Location = new System.Drawing.Point(138, 243);
            this.weightTB.Name = "weightTB";
            this.weightTB.ReadOnly = true;
            this.weightTB.Size = new System.Drawing.Size(161, 20);
            this.weightTB.TabIndex = 108;
            // 
            // heightTB
            // 
            this.heightTB.Location = new System.Drawing.Point(140, 201);
            this.heightTB.Name = "heightTB";
            this.heightTB.ReadOnly = true;
            this.heightTB.Size = new System.Drawing.Size(161, 20);
            this.heightTB.TabIndex = 107;
            // 
            // genderTB
            // 
            this.genderTB.Location = new System.Drawing.Point(140, 162);
            this.genderTB.Name = "genderTB";
            this.genderTB.ReadOnly = true;
            this.genderTB.Size = new System.Drawing.Size(161, 20);
            this.genderTB.TabIndex = 106;
            // 
            // ethnicityTB
            // 
            this.ethnicityTB.Location = new System.Drawing.Point(138, 120);
            this.ethnicityTB.Name = "ethnicityTB";
            this.ethnicityTB.ReadOnly = true;
            this.ethnicityTB.Size = new System.Drawing.Size(161, 20);
            this.ethnicityTB.TabIndex = 105;
            // 
            // dobTB
            // 
            this.dobTB.Location = new System.Drawing.Point(81, 82);
            this.dobTB.Name = "dobTB";
            this.dobTB.ReadOnly = true;
            this.dobTB.Size = new System.Drawing.Size(94, 20);
            this.dobTB.TabIndex = 104;
            // 
            // lNameTB
            // 
            this.lNameTB.Location = new System.Drawing.Point(139, 46);
            this.lNameTB.Name = "lNameTB";
            this.lNameTB.ReadOnly = true;
            this.lNameTB.Size = new System.Drawing.Size(161, 20);
            this.lNameTB.TabIndex = 93;
            // 
            // bmiCategoryLB
            // 
            this.bmiCategoryLB.AutoSize = true;
            this.bmiCategoryLB.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmiCategoryLB.ForeColor = System.Drawing.Color.Black;
            this.bmiCategoryLB.Location = new System.Drawing.Point(146, 347);
            this.bmiCategoryLB.Name = "bmiCategoryLB";
            this.bmiCategoryLB.Size = new System.Drawing.Size(153, 28);
            this.bmiCategoryLB.TabIndex = 103;
            this.bmiCategoryLB.Text = "BMI Category:";
            // 
            // fNameTB
            // 
            this.fNameTB.Location = new System.Drawing.Point(139, 11);
            this.fNameTB.Name = "fNameTB";
            this.fNameTB.ReadOnly = true;
            this.fNameTB.Size = new System.Drawing.Size(161, 20);
            this.fNameTB.TabIndex = 92;
            // 
            // ageLB
            // 
            this.ageLB.AutoSize = true;
            this.ageLB.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLB.ForeColor = System.Drawing.Color.Black;
            this.ageLB.Location = new System.Drawing.Point(180, 75);
            this.ageLB.Name = "ageLB";
            this.ageLB.Size = new System.Drawing.Size(56, 28);
            this.ageLB.TabIndex = 102;
            this.ageLB.Text = "Age:";
            // 
            // bmiLB
            // 
            this.bmiLB.AutoSize = true;
            this.bmiLB.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmiLB.ForeColor = System.Drawing.Color.Black;
            this.bmiLB.Location = new System.Drawing.Point(23, 349);
            this.bmiLB.Name = "bmiLB";
            this.bmiLB.Size = new System.Drawing.Size(60, 28);
            this.bmiLB.TabIndex = 102;
            this.bmiLB.Text = "BMI:";
            // 
            // pcpLB
            // 
            this.pcpLB.AutoSize = true;
            this.pcpLB.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pcpLB.ForeColor = System.Drawing.Color.Black;
            this.pcpLB.Location = new System.Drawing.Point(74, 318);
            this.pcpLB.Name = "pcpLB";
            this.pcpLB.Size = new System.Drawing.Size(58, 28);
            this.pcpLB.TabIndex = 100;
            this.pcpLB.Text = "PCP:";
            // 
            // lNameLB
            // 
            this.lNameLB.AutoSize = true;
            this.lNameLB.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameLB.ForeColor = System.Drawing.Color.Black;
            this.lNameLB.Location = new System.Drawing.Point(14, 38);
            this.lNameLB.Name = "lNameLB";
            this.lNameLB.Size = new System.Drawing.Size(121, 28);
            this.lNameLB.TabIndex = 93;
            this.lNameLB.Text = "Last Name:";
            // 
            // dobLB
            // 
            this.dobLB.AutoSize = true;
            this.dobLB.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobLB.ForeColor = System.Drawing.Color.Black;
            this.dobLB.Location = new System.Drawing.Point(14, 75);
            this.dobLB.Name = "dobLB";
            this.dobLB.Size = new System.Drawing.Size(66, 28);
            this.dobLB.TabIndex = 94;
            this.dobLB.Text = "DOB:";
            // 
            // ethnicityLB
            // 
            this.ethnicityLB.AutoSize = true;
            this.ethnicityLB.BackColor = System.Drawing.Color.Transparent;
            this.ethnicityLB.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ethnicityLB.ForeColor = System.Drawing.Color.Black;
            this.ethnicityLB.Location = new System.Drawing.Point(25, 115);
            this.ethnicityLB.Name = "ethnicityLB";
            this.ethnicityLB.Size = new System.Drawing.Size(108, 28);
            this.ethnicityLB.TabIndex = 95;
            this.ethnicityLB.Text = "Ethnicity:";
            // 
            // genderLB
            // 
            this.genderLB.AutoSize = true;
            this.genderLB.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLB.ForeColor = System.Drawing.Color.Black;
            this.genderLB.Location = new System.Drawing.Point(42, 158);
            this.genderLB.Name = "genderLB";
            this.genderLB.Size = new System.Drawing.Size(92, 28);
            this.genderLB.TabIndex = 96;
            this.genderLB.Text = "Gender:";
            // 
            // heightLB
            // 
            this.heightLB.AutoSize = true;
            this.heightLB.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightLB.ForeColor = System.Drawing.Color.Black;
            this.heightLB.Location = new System.Drawing.Point(72, 245);
            this.heightLB.Name = "heightLB";
            this.heightLB.Size = new System.Drawing.Size(86, 28);
            this.heightLB.TabIndex = 97;
            this.heightLB.Text = "Height:";
            // 
            // weightLB
            // 
            this.weightLB.AutoSize = true;
            this.weightLB.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightLB.ForeColor = System.Drawing.Color.Black;
            this.weightLB.Location = new System.Drawing.Point(67, 284);
            this.weightLB.Name = "weightLB";
            this.weightLB.Size = new System.Drawing.Size(88, 28);
            this.weightLB.TabIndex = 98;
            this.weightLB.Text = "Weight:";
            // 
            // allergiesLB
            // 
            this.allergiesLB.AutoSize = true;
            this.allergiesLB.BackColor = System.Drawing.Color.Transparent;
            this.allergiesLB.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allergiesLB.ForeColor = System.Drawing.Color.Black;
            this.allergiesLB.Location = new System.Drawing.Point(54, 324);
            this.allergiesLB.Name = "allergiesLB";
            this.allergiesLB.Size = new System.Drawing.Size(105, 28);
            this.allergiesLB.TabIndex = 99;
            this.allergiesLB.Text = "Allergies:";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(22, 469);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(316, 36);
            this.exitButton.TabIndex = 92;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // DisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(358, 514);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.allergiesLB);
            this.Controls.Add(this.weightLB);
            this.Controls.Add(this.heightLB);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DisplayForm";
            this.Text = "Saint Augustine Health System";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fNameLB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label pcpLB;
        private System.Windows.Forms.Label lNameLB;
        private System.Windows.Forms.Label dobLB;
        private System.Windows.Forms.Label ethnicityLB;
        private System.Windows.Forms.Label genderLB;
        private System.Windows.Forms.Label heightLB;
        private System.Windows.Forms.Label weightLB;
        private System.Windows.Forms.Label allergiesLB;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label bmiCategoryLB;
        private System.Windows.Forms.Label ageLB;
        private System.Windows.Forms.Label bmiLB;
        private System.Windows.Forms.TextBox ageTB;
        private System.Windows.Forms.TextBox bmiCategoryTB;
        private System.Windows.Forms.TextBox bmiTB;
        private System.Windows.Forms.TextBox pcpTB;
        private System.Windows.Forms.TextBox allergiesTB;
        private System.Windows.Forms.TextBox weightTB;
        private System.Windows.Forms.TextBox heightTB;
        private System.Windows.Forms.TextBox genderTB;
        private System.Windows.Forms.TextBox ethnicityTB;
        private System.Windows.Forms.TextBox dobTB;
        private System.Windows.Forms.TextBox lNameTB;
        private System.Windows.Forms.TextBox fNameTB;
    }
}