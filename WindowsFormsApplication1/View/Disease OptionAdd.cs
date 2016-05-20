using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DoctorsHandBook.Model;

namespace DoctorsHandBook.View
{
    public partial class DiseaseOptionAdd : Form
    {
        public Disease Disease { get; set; }
        List<string> _meds = new List<string>();

        public DiseaseOptionAdd()
        {
            InitializeComponent();
        }

        private void Disease_OptionAdd_Load(object sender, EventArgs e)
        {
        }

        private void btnMedSave_Click(object sender, EventArgs e)
        {
            string title = tBoxDiseaseTitle.Text.Trim();
            string sympt = rTBoxDiseaseSympt.Text.Trim();
            string proced = rTBoxDiseaseProced.Text.Trim();
            Disease = new Disease(title, sympt, proced, _meds);
            Close();
        }

        private void btnMedCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPlusMed_Click(object sender, EventArgs e)
        {
            if (tBoxDiseaseMeds.Text.Trim() != "")
            {
                _meds.Add(tBoxDiseaseMeds.Text.Trim());
                lBoxDiseaseMed.Items.Add(tBoxDiseaseMeds.Text.Trim());
                lBoxDiseaseMed.Refresh();
                tBoxDiseaseMeds.Clear();
                
            }
        }

        private void btnMinusMed_Click(object sender, EventArgs e)
        {
            if(lBoxDiseaseMed.SelectedIndex != -1)
            {
                _meds.RemoveAt(lBoxDiseaseMed.SelectedIndex);
                lBoxDiseaseMed.Items.RemoveAt(lBoxDiseaseMed.SelectedIndex);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
