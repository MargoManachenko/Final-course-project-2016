using System;
using System.Windows.Forms;
using DoctorsHandBook.Model;

namespace DoctorsHandBook.View
{
    public partial class MedOptionEdit : Form
    {
        public Medication NewMed { get; set; }
       

        public MedOptionEdit(Medication med)
        {
            InitializeComponent();
            tBoxMedTitle.Text = med.Title;
            rtBoxMedDescription.Text = med.Description;
            numUDUnit.Value = med.DoseUnit;
            numUDPortion.Value = med.DosePortion;
            numUDPeriod.Value = med.DosePeriod;
            numUDinStock.Value = med.QuantityInStock;

        }

        private void btnMedSave_Click(object sender, EventArgs e)
        {
            if (tBoxMedTitle.Text.Trim() == "" || rtBoxMedDescription.Text.Trim() == "")
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

                NewMed = new Medication(title, description, doseUnit, dosePortion, dosePeriod,quantity);

                Close();
            }
        }

        private void Med_OptionEdit_Load(object sender, EventArgs e)
        {
            
        }

        private void btnMedCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rtBoxMedDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void numUDinStock_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
