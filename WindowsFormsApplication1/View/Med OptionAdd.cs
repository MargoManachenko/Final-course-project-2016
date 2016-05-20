using System;
using System.Windows.Forms;
using DoctorsHandBook.Model;


namespace DoctorsHandBook.View
{
    public partial class MedOptionAdd : Form
    {
        public Medication Med { get; set; }

        public MedOptionAdd()
        {
            InitializeComponent();
        }

        private void Med_Options_Load(object sender, EventArgs e)
        {        
                
        }

        private void buttonMedAdd_Click(object sender, EventArgs e)
        {

        }

        private void textBoxMedTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtBoxMedDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonMedSave_Click(object sender, EventArgs e)
        {
            if(tBoxMedTitle.Text.Trim() == "" || rtBoxMedDescription.Text.Trim() == "")
            {
                MessageBox.Show("Complete all fields");
            }
            else
            {
                string title = tBoxMedTitle.Text.Trim();
                string description = rtBoxMedDescription.Text.Trim();
                int doseUnit = Convert.ToInt32(numUDUnit.Value);
                int dosePortion = Convert.ToInt32(numUDPortion.Value);
                int dosePeriod = Convert.ToInt32(numUDPeriod.Value);
                int quantity = Convert.ToInt32(numUDinStock.Value);

                Med = new Medication(title, description, doseUnit, dosePortion, dosePeriod, quantity);
                Close();

            }
        }

        private void btnMedCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
