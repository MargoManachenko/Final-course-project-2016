using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;
using DoctorsHandBook.Model;

namespace DoctorsHandBook.View
{
    public partial class DiseasesControl : Form
    {
        private DiseasesManager _diseaseManager;
        private MedsManager _medsManager;
        private Disease _oldDisease;

        public DiseasesControl()
        {
            InitializeComponent();
            _diseaseManager = new DiseasesManager();

        }

        private void Diseases_Control_Load(object sender, EventArgs e)
        {
            _diseaseManager.Init();

            try
            {
                DiseaseDataGrid.DataSource = _diseaseManager.GetDisiases();

            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            FitToContent();
            cmbBoxSearch.SelectedIndex = 0;

        }


        //изменение расположения колонок DataGridView
        private void FitToContent()
        {
            DiseaseDataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }


        private void buttonDiseaseDelete_Click(object sender, EventArgs e)
        {
            if (DiseaseDataGrid.CurrentRow == null) return;
            var dialogResult = MessageBox.Show(@"Delete selected disease?", @"Delete", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes) return;
            var selectedMed = DiseaseDataGrid.CurrentRow.Cells[0].Value.ToString();
            _diseaseManager.Delete(selectedMed);
            _diseaseManager.Update();
            RefreshDatabase();

        }

        private void RefreshDatabase()
        {
            _diseaseManager.Update();
            _diseaseManager.Init();
            try
            {
                DiseaseDataGrid.DataSource = _diseaseManager.GetDisiases();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //получение списка лекарств в нужном нам виде, парсинг строки
        private static List<string> GetTreatment(string current)
        {
            var treatm = new List<string>();
            var med = "";
            for (int i = 0; i < current.Length; i++)
            {
                if (current[i] != ',')
                {
                    med += current[i];
                }
                if (current[i] == ',' || i == current.Length - 1)
                {
                    treatm.Add(med.Trim());
                    med = "";
                }
            }
            return treatm;
        }

        private void DiseasesDataBase_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       


        private void btnAdd_Click(object sender, EventArgs e)
        {
            DiseaseOptionAdd formAdd = new DiseaseOptionAdd();
            formAdd.FormClosed += FormAdd_FormClosed;
            formAdd.ShowDialog();
        }

        private void FormAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            var formAdd = (DiseaseOptionAdd)sender;
            if (formAdd.Disease != null)
            {
                _diseaseManager.Add(formAdd.Disease);
            }
            RefreshDatabase();
        }

        private void btnMedEdit_Click(object sender, EventArgs e)
        {
            if (DiseaseDataGrid.CurrentRow != null)
            {
                var title = DiseaseDataGrid.CurrentRow.Cells[0].Value.ToString();
                var sympt = DiseaseDataGrid.CurrentRow.Cells[1].Value.ToString();
                var proced = DiseaseDataGrid.CurrentRow.Cells[2].Value.ToString();
                var cur = DiseaseDataGrid.CurrentRow.Cells[3].Value.ToString();
                var treatment = GetTreatment(cur);
                _oldDisease = new Disease(title, sympt, proced, treatment);

            }

            DiseaseOptionEdit formEdit = new DiseaseOptionEdit(_oldDisease);
            formEdit.FormClosed += FormEdit_FormClosed;
            formEdit.ShowDialog();

        }

        private void FormEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            var formEdit = (DiseaseOptionEdit)sender;
            if (formEdit.NewDisease != null)
            {
                _diseaseManager.Edit(_oldDisease, formEdit.NewDisease);
            }
            RefreshDatabase();
        }

        private void cmbBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            tBoxDisSearch.Clear();
            DiseaseDataGrid.ClearSelection();
        }

        private void tBoxDisSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDisSearch_Click(object sender, EventArgs e)
        {
            var limit = cmbBoxSearch.SelectedIndex;

            if (string.IsNullOrEmpty(tBoxDisSearch.Text)) return;
            for (var i = 0; i < DiseaseDataGrid.RowCount; i++)
            {
                DiseaseDataGrid.Rows[i].Selected = false;

                if (DiseaseDataGrid.Rows[i].Cells[limit].Value == null) continue;
                if (DiseaseDataGrid.Rows[i].Cells[limit].Value.ToString().Contains(tBoxDisSearch.Text.Trim()))
                {
                    DiseaseDataGrid.Rows[i].Selected = true;
                }
            }

        }
    }
}
