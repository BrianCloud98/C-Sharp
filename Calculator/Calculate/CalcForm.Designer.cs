namespace MultiCalc
{
    partial class CalcForm
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
            this.panelBasic = new System.Windows.Forms.Panel();
            this.totalTB = new System.Windows.Forms.TextBox();
            this.historyTB = new System.Windows.Forms.TextBox();
            this.labelBasic = new System.Windows.Forms.Label();
            this.equalsBTN = new System.Windows.Forms.Button();
            this.divideBTN = new System.Windows.Forms.Button();
            this.multiplyBTN = new System.Windows.Forms.Button();
            this.subtractBTN = new System.Windows.Forms.Button();
            this.addBTN = new System.Windows.Forms.Button();
            this.BTN1 = new System.Windows.Forms.Button();
            this.BTN2 = new System.Windows.Forms.Button();
            this.BTN3 = new System.Windows.Forms.Button();
            this.BTN5 = new System.Windows.Forms.Button();
            this.BTN7 = new System.Windows.Forms.Button();
            this.BTN8 = new System.Windows.Forms.Button();
            this.BTN9 = new System.Windows.Forms.Button();
            this.BTN0 = new System.Windows.Forms.Button();
            this.BTN6 = new System.Windows.Forms.Button();
            this.BTN4 = new System.Windows.Forms.Button();
            this.BTNdecimal = new System.Windows.Forms.Button();
            this.clearBTN = new System.Windows.Forms.Button();
            this.allClearBTN = new System.Windows.Forms.Button();
            this.panelBasic.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBasic
            // 
            this.panelBasic.BackColor = System.Drawing.Color.DarkGray;
            this.panelBasic.Controls.Add(this.allClearBTN);
            this.panelBasic.Controls.Add(this.clearBTN);
            this.panelBasic.Controls.Add(this.BTNdecimal);
            this.panelBasic.Controls.Add(this.totalTB);
            this.panelBasic.Controls.Add(this.historyTB);
            this.panelBasic.Controls.Add(this.labelBasic);
            this.panelBasic.Controls.Add(this.equalsBTN);
            this.panelBasic.Controls.Add(this.divideBTN);
            this.panelBasic.Controls.Add(this.multiplyBTN);
            this.panelBasic.Controls.Add(this.subtractBTN);
            this.panelBasic.Controls.Add(this.addBTN);
            this.panelBasic.Controls.Add(this.BTN1);
            this.panelBasic.Controls.Add(this.BTN2);
            this.panelBasic.Controls.Add(this.BTN3);
            this.panelBasic.Controls.Add(this.BTN5);
            this.panelBasic.Controls.Add(this.BTN7);
            this.panelBasic.Controls.Add(this.BTN8);
            this.panelBasic.Controls.Add(this.BTN9);
            this.panelBasic.Controls.Add(this.BTN0);
            this.panelBasic.Controls.Add(this.BTN6);
            this.panelBasic.Controls.Add(this.BTN4);
            this.panelBasic.Location = new System.Drawing.Point(-8, 1);
            this.panelBasic.Name = "panelBasic";
            this.panelBasic.Size = new System.Drawing.Size(299, 470);
            this.panelBasic.TabIndex = 1;
            // 
            // totalTB
            // 
            this.totalTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTB.Location = new System.Drawing.Point(129, 408);
            this.totalTB.Name = "totalTB";
            this.totalTB.Size = new System.Drawing.Size(148, 47);
            this.totalTB.TabIndex = 21;
            // 
            // historyTB
            // 
            this.historyTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyTB.Location = new System.Drawing.Point(23, 408);
            this.historyTB.Name = "historyTB";
            this.historyTB.Size = new System.Drawing.Size(100, 47);
            this.historyTB.TabIndex = 20;
            // 
            // labelBasic
            // 
            this.labelBasic.AutoSize = true;
            this.labelBasic.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBasic.ForeColor = System.Drawing.Color.Black;
            this.labelBasic.Location = new System.Drawing.Point(58, 8);
            this.labelBasic.Name = "labelBasic";
            this.labelBasic.Size = new System.Drawing.Size(172, 37);
            this.labelBasic.TabIndex = 19;
            this.labelBasic.Text = "Calculator";
            // 
            // equalsBTN
            // 
            this.equalsBTN.BackColor = System.Drawing.Color.Black;
            this.equalsBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.equalsBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalsBTN.ForeColor = System.Drawing.Color.White;
            this.equalsBTN.Location = new System.Drawing.Point(130, 338);
            this.equalsBTN.Name = "equalsBTN";
            this.equalsBTN.Size = new System.Drawing.Size(147, 50);
            this.equalsBTN.TabIndex = 16;
            this.equalsBTN.Text = "=";
            this.equalsBTN.UseVisualStyleBackColor = false;
            this.equalsBTN.Click += new System.EventHandler(this.buttonEquals_Click);
            // 
            // divideBTN
            // 
            this.divideBTN.BackColor = System.Drawing.Color.Red;
            this.divideBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.divideBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideBTN.Location = new System.Drawing.Point(227, 272);
            this.divideBTN.Name = "divideBTN";
            this.divideBTN.Size = new System.Drawing.Size(50, 50);
            this.divideBTN.TabIndex = 15;
            this.divideBTN.Text = "/";
            this.divideBTN.UseVisualStyleBackColor = false;
            this.divideBTN.Click += new System.EventHandler(this.buttonDivide_Click);
            // 
            // multiplyBTN
            // 
            this.multiplyBTN.BackColor = System.Drawing.Color.Yellow;
            this.multiplyBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.multiplyBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyBTN.Location = new System.Drawing.Point(227, 201);
            this.multiplyBTN.Name = "multiplyBTN";
            this.multiplyBTN.Size = new System.Drawing.Size(50, 50);
            this.multiplyBTN.TabIndex = 14;
            this.multiplyBTN.Text = "*";
            this.multiplyBTN.UseVisualStyleBackColor = false;
            this.multiplyBTN.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // subtractBTN
            // 
            this.subtractBTN.BackColor = System.Drawing.Color.GreenYellow;
            this.subtractBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.subtractBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtractBTN.Location = new System.Drawing.Point(227, 134);
            this.subtractBTN.Name = "subtractBTN";
            this.subtractBTN.Size = new System.Drawing.Size(50, 50);
            this.subtractBTN.TabIndex = 13;
            this.subtractBTN.Text = "-";
            this.subtractBTN.UseVisualStyleBackColor = false;
            this.subtractBTN.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // addBTN
            // 
            this.addBTN.BackColor = System.Drawing.Color.DodgerBlue;
            this.addBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBTN.Location = new System.Drawing.Point(227, 60);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(50, 50);
            this.addBTN.TabIndex = 12;
            this.addBTN.Text = "+";
            this.addBTN.UseVisualStyleBackColor = false;
            this.addBTN.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // BTN1
            // 
            this.BTN1.BackColor = System.Drawing.Color.DimGray;
            this.BTN1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN1.Location = new System.Drawing.Point(23, 60);
            this.BTN1.Name = "BTN1";
            this.BTN1.Size = new System.Drawing.Size(50, 50);
            this.BTN1.TabIndex = 2;
            this.BTN1.Text = "1";
            this.BTN1.UseVisualStyleBackColor = false;
            this.BTN1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTN2
            // 
            this.BTN2.BackColor = System.Drawing.Color.DimGray;
            this.BTN2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN2.Location = new System.Drawing.Point(89, 60);
            this.BTN2.Name = "BTN2";
            this.BTN2.Size = new System.Drawing.Size(50, 50);
            this.BTN2.TabIndex = 3;
            this.BTN2.Text = "2";
            this.BTN2.UseVisualStyleBackColor = false;
            this.BTN2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTN3
            // 
            this.BTN3.BackColor = System.Drawing.Color.DimGray;
            this.BTN3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN3.Location = new System.Drawing.Point(159, 59);
            this.BTN3.Name = "BTN3";
            this.BTN3.Size = new System.Drawing.Size(50, 50);
            this.BTN3.TabIndex = 4;
            this.BTN3.Text = "3";
            this.BTN3.UseVisualStyleBackColor = false;
            this.BTN3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BTN5
            // 
            this.BTN5.BackColor = System.Drawing.Color.DimGray;
            this.BTN5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN5.Location = new System.Drawing.Point(89, 130);
            this.BTN5.Name = "BTN5";
            this.BTN5.Size = new System.Drawing.Size(50, 50);
            this.BTN5.TabIndex = 6;
            this.BTN5.Text = "5";
            this.BTN5.UseVisualStyleBackColor = false;
            this.BTN5.Click += new System.EventHandler(this.button5_Click);
            // 
            // BTN7
            // 
            this.BTN7.BackColor = System.Drawing.Color.DimGray;
            this.BTN7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN7.Location = new System.Drawing.Point(23, 201);
            this.BTN7.Name = "BTN7";
            this.BTN7.Size = new System.Drawing.Size(50, 50);
            this.BTN7.TabIndex = 8;
            this.BTN7.Text = "7";
            this.BTN7.UseVisualStyleBackColor = false;
            this.BTN7.Click += new System.EventHandler(this.button7_Click);
            // 
            // BTN8
            // 
            this.BTN8.BackColor = System.Drawing.Color.DimGray;
            this.BTN8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN8.Location = new System.Drawing.Point(89, 201);
            this.BTN8.Name = "BTN8";
            this.BTN8.Size = new System.Drawing.Size(50, 50);
            this.BTN8.TabIndex = 9;
            this.BTN8.Text = "8";
            this.BTN8.UseVisualStyleBackColor = false;
            this.BTN8.Click += new System.EventHandler(this.button8_Click);
            // 
            // BTN9
            // 
            this.BTN9.BackColor = System.Drawing.Color.DimGray;
            this.BTN9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN9.Location = new System.Drawing.Point(159, 201);
            this.BTN9.Name = "BTN9";
            this.BTN9.Size = new System.Drawing.Size(50, 50);
            this.BTN9.TabIndex = 10;
            this.BTN9.Text = "9";
            this.BTN9.UseVisualStyleBackColor = false;
            this.BTN9.Click += new System.EventHandler(this.button9_Click);
            // 
            // BTN0
            // 
            this.BTN0.BackColor = System.Drawing.Color.DimGray;
            this.BTN0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN0.Location = new System.Drawing.Point(23, 272);
            this.BTN0.Name = "BTN0";
            this.BTN0.Size = new System.Drawing.Size(50, 50);
            this.BTN0.TabIndex = 11;
            this.BTN0.Text = "0";
            this.BTN0.UseVisualStyleBackColor = false;
            this.BTN0.Click += new System.EventHandler(this.button0_Click);
            // 
            // BTN6
            // 
            this.BTN6.BackColor = System.Drawing.Color.DimGray;
            this.BTN6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN6.Location = new System.Drawing.Point(159, 130);
            this.BTN6.Name = "BTN6";
            this.BTN6.Size = new System.Drawing.Size(50, 50);
            this.BTN6.TabIndex = 7;
            this.BTN6.Text = "6";
            this.BTN6.UseVisualStyleBackColor = false;
            this.BTN6.Click += new System.EventHandler(this.button6_Click);
            // 
            // BTN4
            // 
            this.BTN4.BackColor = System.Drawing.Color.DimGray;
            this.BTN4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN4.Location = new System.Drawing.Point(23, 130);
            this.BTN4.Name = "BTN4";
            this.BTN4.Size = new System.Drawing.Size(50, 50);
            this.BTN4.TabIndex = 5;
            this.BTN4.Text = "4";
            this.BTN4.UseVisualStyleBackColor = false;
            this.BTN4.Click += new System.EventHandler(this.button4_Click);
            // 
            // BTNdecimal
            // 
            this.BTNdecimal.BackColor = System.Drawing.Color.DimGray;
            this.BTNdecimal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNdecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNdecimal.Location = new System.Drawing.Point(89, 272);
            this.BTNdecimal.Name = "BTNdecimal";
            this.BTNdecimal.Size = new System.Drawing.Size(50, 50);
            this.BTNdecimal.TabIndex = 22;
            this.BTNdecimal.Text = ".";
            this.BTNdecimal.UseVisualStyleBackColor = false;
            // 
            // clearBTN
            // 
            this.clearBTN.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.clearBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBTN.Location = new System.Drawing.Point(159, 272);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(50, 50);
            this.clearBTN.TabIndex = 23;
            this.clearBTN.Text = "C";
            this.clearBTN.UseVisualStyleBackColor = false;
            this.clearBTN.Click += new System.EventHandler(this.clearBTN_Click);
            // 
            // allClearBTN
            // 
            this.allClearBTN.BackColor = System.Drawing.Color.Gainsboro;
            this.allClearBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.allClearBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allClearBTN.ForeColor = System.Drawing.Color.Black;
            this.allClearBTN.Location = new System.Drawing.Point(20, 338);
            this.allClearBTN.Name = "allClearBTN";
            this.allClearBTN.Size = new System.Drawing.Size(104, 50);
            this.allClearBTN.TabIndex = 24;
            this.allClearBTN.Text = "AC";
            this.allClearBTN.UseVisualStyleBackColor = false;
            this.allClearBTN.Click += new System.EventHandler(this.allClearBTN_Click);
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(282, 466);
            this.Controls.Add(this.panelBasic);
            this.Name = "CalcForm";
            this.panelBasic.ResumeLayout(false);
            this.panelBasic.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBasic;
        private System.Windows.Forms.Label labelBasic;
        private System.Windows.Forms.Button equalsBTN;
        private System.Windows.Forms.Button divideBTN;
        private System.Windows.Forms.Button multiplyBTN;
        private System.Windows.Forms.Button subtractBTN;
        private System.Windows.Forms.Button addBTN;
        private System.Windows.Forms.Button BTN1;
        private System.Windows.Forms.Button BTN2;
        private System.Windows.Forms.Button BTN3;
        private System.Windows.Forms.Button BTN5;
        private System.Windows.Forms.Button BTN7;
        private System.Windows.Forms.Button BTN8;
        private System.Windows.Forms.Button BTN9;
        private System.Windows.Forms.Button BTN0;
        private System.Windows.Forms.Button BTN6;
        private System.Windows.Forms.Button BTN4;
        private System.Windows.Forms.TextBox totalTB;
        private System.Windows.Forms.TextBox historyTB;
        private System.Windows.Forms.Button allClearBTN;
        private System.Windows.Forms.Button clearBTN;
        private System.Windows.Forms.Button BTNdecimal;
    }
}

