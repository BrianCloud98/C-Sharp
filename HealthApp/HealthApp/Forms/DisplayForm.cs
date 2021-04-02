using System;
using System.Windows.Forms;

namespace HealthApp
{
    public partial class DisplayForm : Form
    {
        public DisplayForm()
        {
            InitializeComponent();
        }

        public DisplayForm(Client client)
        {
            InitializeComponent();
            fName.Text = client.firstName;
            lNameTB.Text = client.lastName;
            dobTB.Text = client.birthMonth + "/" + client.birthDay + "/" + client.birthYear;
            ageTB.Text = Convert.ToString(DateTime.Today.Year - client.birthYear);
            ethnicityTB.Text = client.ethnicity;
            genderTB.Text = client.gender;
            heightTB.Text = client.heightFt + "\' " + client.heightIn + "\"";
            weightTB.Text = Convert.ToString(client.weight) + " lbs.";
            allergiesTB.Text = client.allergy;
            pcpTB.Text = client.pcp;
            bmiTB.Text = Convert.ToString(client.bmi);
            bmiCategoryTB.Text = client.bmiCategory;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
