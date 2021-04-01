﻿using Health_App.HealthApp.Forms;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace HealthApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                new MainForm();
                Client client = new Client();

                if (string.IsNullOrEmpty(fNameTB.Text) && string.IsNullOrEmpty(lNameTB.Text) && string.IsNullOrEmpty(ethnicityCB.Text) && string.IsNullOrEmpty(genderCB.Text) && string.IsNullOrEmpty(heightFtNUD.Text)
                    && string.IsNullOrEmpty(weightNUD.Text) && string.IsNullOrEmpty(DOBYearNUD.Text) && string.IsNullOrEmpty(DOBMonthNUD.Text) && string.IsNullOrEmpty(DOBDayNUD.Text) && (yesRB.Checked || noRB.Checked) && string.IsNullOrEmpty(PCPCB.Text))
                {
                    client.firstName = fNameTB.Text;
                    client.lastName = lNameTB.Text;
                    client.ethnicity = ethnicityCB.Text;
                    client.gender = genderCB.Text;
                    client.heightFt = Int32.Parse(heightFtNUD.Text);
                    client.heightIn = Int32.Parse(heightInNUD.Text);
                    client.weight = Int32.Parse(weightNUD.Text);
                    client.birthYear = Int32.Parse(DOBYearNUD.Text);
                    client.birthMonth = Int32.Parse(DOBMonthNUD.Text);
                    client.birthDay = Int32.Parse(DOBDayNUD.Text);
                    client.allergy = yesRB.Checked ? "Yes" : "No";
                    client.pcp = PCPCB.Text;

                    new DisplayForm(client);
                }
                else
                {
                    throw new CustomException("Field cannot be blank.");
                }
            }
            catch (Exception error)
            {
                new CustomException("Error extrapolating form data.", error);
            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}