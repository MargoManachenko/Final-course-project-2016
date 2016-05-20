using System;
using System.Windows.Forms;
using DoctorsHandBook.Model;
using DoctorsHandBook.View;

namespace DoctorsHandBook
{
    public partial class MedsControl : Form
    {
        private MedsManager _medsManager;
        private Medication _oldMed;

        public MedsControl()
        {
            InitializeComponent();
            _medsManager = new MedsManager();
        }

        private void RefreshDatabase()
        {
            try
            {
                _medsManager.Update();
                _medsManager.Init();
                MedsDataGrid.DataSource = _medsManager.GetMeds();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Meds_Control_Load(object sender, EventArgs e)
        {
            _medsManager.Init();

            try
            {
                MedsDataGrid.DataSource = _medsManager.GetMeds();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MedsDataGrid.Columns[0].HeaderText = @"Title";
            MedsDataGrid.Columns[2].HeaderText = @"Quantity of intake";
            MedsDataGrid.Columns[3].HeaderText = @"Frequence of intake";
            MedsDataGrid.Columns[4].HeaderText = "Period of \nintake (days)";
            MedsDataGrid.Columns[5].HeaderText = @"In stock";
            MedsDataGrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            FitToContent();

            cmbBoxSearch.SelectedIndex = 0;
        }

        //Расположение данных в таблице
        private void FitToContent()
        {
            for (var i = 0; i < 6; i++)
            {
                if (i != 1)
                {
                    MedsDataGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    continue;
                }
                MedsDataGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }


        private void Meds_Control_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                _medsManager.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonMedDelete_Click(object sender, EventArgs e)
        {
            if (MedsDataGrid.CurrentRow == null) return;

            DialogResult result = MessageBox.Show("Delete selected medication?", "Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string selectedMed = MedsDataGrid.CurrentRow.Cells[0].Value.ToString();
                _medsManager.Delete(selectedMed);
                _medsManager.Update();
                RefreshDatabase();

            }
        }

        private void buttonMedEdit_Click(object sender, EventArgs e)
        {
            if (MedsDataGrid.CurrentRow != null)
            {
                string title = MedsDataGrid.CurrentRow.Cells[0].Value.ToString();
                string description = MedsDataGrid.CurrentRow.Cells[1].Value.ToString();
                int doseUnit = Convert.ToInt32(MedsDataGrid.CurrentRow.Cells[2].Value);
                int dosePortion = Convert.ToInt32(MedsDataGrid.CurrentRow.Cells[3].Value);
                int dosePeriod = Convert.ToInt32(MedsDataGrid.CurrentRow.Cells[4].Value);
                int quantity = Convert.ToInt32(MedsDataGrid.CurrentRow.Cells[5].Value);

                _oldMed = new Medication(title, description, doseUnit, dosePortion, dosePeriod, quantity);

                MedOptionEdit fOptionEdit = new MedOptionEdit(_oldMed);
                fOptionEdit.FormClosed += FOptionsEdit_FormClosed;
                fOptionEdit.ShowDialog();

            }
        }

        private void FOptionsEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            var fOptionsEdit = (MedOptionEdit)sender;
            if (fOptionsEdit.NewMed != null)
            {
                _medsManager.Edit(_oldMed, fOptionsEdit.NewMed);
            }

            RefreshDatabase();
        }
        private void FOptionsAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            var fOptionsAdd = (MedOptionAdd)sender;
            if (fOptionsAdd.Med != null)
            {
                _medsManager.AddMed(fOptionsAdd.Med);
            }

            RefreshDatabase();
        }
        private void Add_Click(object sender, EventArgs e)
        {
            MedOptionAdd fOptionsAdd = new MedOptionAdd();
            fOptionsAdd.FormClosed += FOptionsAdd_FormClosed;
            fOptionsAdd.ShowDialog();
        }
        private void btnMedSearch_Click(object sender, EventArgs e)
        {
            int limit = cmbBoxSearch.SelectedIndex;

            if (tBoxMedSearch.Text.Trim() != "")
            {
                for (int i = 0; i < MedsDataGrid.RowCount; i++)
                {
                    MedsDataGrid.Rows[i].Selected = false;

                    if (MedsDataGrid.Rows[i].Cells[limit].Value != null)
                    {
                        if (MedsDataGrid.Rows[i].Cells[limit].Value.ToString().Contains(tBoxMedSearch.Text.Trim()))
                        {
                            MedsDataGrid.Rows[i].Selected = true;
                        }
                    }
                }
            }

        }
        private void CmbBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            tBoxMedSearch.Clear();
            MedsDataGrid.ClearSelection();
        }

        private void MedsDataBase_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
