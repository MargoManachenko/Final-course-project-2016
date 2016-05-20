using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DoctorsHandBook.Model;

namespace DoctorsHandBook.View
{
    public partial class DiseaseOptionEdit : Form
    {
        public Disease NewDisease { get; set; }

        public DiseaseOptionEdit(Disease dis)
        {
            InitializeComponent();

            tBoxDiseaseTitle.Text = dis.Title;
            rTBoxDiseaseSympt.Text = dis.Symptoms;
            rTBoxDiseaseProced.Text = dis.Procedures;

            foreach(var x in dis.Treatment)
            {
                lBoxDiseaseMed.Items.Add(x);
            }
        }

        private void Disease_OptionEdit_Load(object sender, EventArgs e)
        {

        }

        private void btnMedCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMedSave_Click(object sender, EventArgs e)
        {
            string title = tBoxDiseaseTitle.Text.Trim();
            string sympt = rTBoxDiseaseSympt.Text.Trim();
            string proced = rTBoxDiseaseProced.Text.Trim();
            List<string> meds = new List<string>();
            meds.AddRange(lBoxDiseaseMed.Items.Cast<string>());
            NewDisease = new Disease(title, sympt, proced, meds);
            Close();
        }

        private void btnPlusMed_Click(object sender, EventArgs e)
        {
            if (tBoxDiseaseMeds.Text.Trim() != "")
            {
                lBoxDiseaseMed.Items.Add(tBoxDiseaseMeds.Text.Trim());
                lBoxDiseaseMed.Refresh();
                tBoxDiseaseMeds.Clear();

            }
        }

        private void btnMinusMed_Click(object sender, EventArgs e)
        {
            if (lBoxDiseaseMed.SelectedIndex != -1)
            {
                lBoxDiseaseMed.Items.RemoveAt(lBoxDiseaseMed.SelectedIndex);
            }
        }

        private void tBoxDiseaseMeds_TextChanged(object sender, EventArgs e)
        {

        }

        private void lBoxDiseaseMed_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
