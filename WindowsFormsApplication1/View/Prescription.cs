using DoctorsHandBook.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace WindowsFormsApplication1.View
{
    public partial class Prescription : Form
    {

        private readonly MedsManager _medsManager;
        private readonly DiseasesManager _diseaseManager;


        //создание коллекции строк для хранения списка лекарсв
        private List<string> _recipe;
        private string _name = "";


        public Prescription()
        {
            InitializeComponent();
            _diseaseManager = new DiseasesManager();
            _medsManager = new MedsManager();
        }

        private void Prescription_Load(object sender, EventArgs e)
        {
            try
            {
                _diseaseManager.Init();
                _medsManager.Init();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        //очистка контролов
        private void ClearConrols()
        {
            chLBMeds.Items.Clear();
            chLBOut.Items.Clear();
            pnlPresc.Controls.Clear();
            lblHeaderD.Visible = false;
            lblHeaderO.Visible = false;
            lblHeaderP.Visible = false;
            lblProced.Visible = false;
        }



        private void btnPrescrSearch_Click(object sender, EventArgs e)
        {
            ClearConrols();
            var outOfStock = true;
            var search = tBoxDiseaseSearch.Text.Trim();
            if (string.IsNullOrEmpty(search)) return;

            var recipe = _diseaseManager.GetTreatment(search);

            lblHeaderD.Visible = true;
            chLBMeds.Visible = true;
            lblHeaderD.Text = "Treatment: ";

            if (recipe != null)
            {
                foreach (var med in recipe.MedsRecipe)
                {
                    if (!_medsManager[med])
                    {
                        chLBOut.Visible = true;
                        lblHeaderO.Visible = true;
                        lblHeaderO.Text = @"Medications out of stock:";
                        var l = new ListItem { Value = med };
                        chLBOut.Items.Add(l);
                    }
                    else
                    {
                        outOfStock = false;
                        _name = recipe.DiseaseTitle;
                        if (string.IsNullOrEmpty(med)) return;
                        lblHeaderD.Text = @"Treatment for " + recipe.DiseaseTitle + "\nMedications in stock:";
                        lblHeaderD.Visible = true;
                        chLBMeds.Visible = true;
                        var l = new ListItem { Value = med };
                        chLBMeds.Items.Add(l);
                    }
                }

                lblHeaderP.Text = @"Procedures: ";
                lblHeaderP.Visible = true;
                lblProced.Text = recipe.ProceduresRecipe;
                lblProced.Visible = true;
                if (outOfStock)
                {
                    lblHeaderD.Text = @"No medications in stock";
                    lblHeaderD.Visible = true;
                }
            }

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tBoxDiseaseSearch.Text.Trim())) return;
            _recipe = new List<string>();

            foreach (ListItem item in chLBMeds.CheckedItems)
            {
                _recipe.Add(item.Text);
            }

            var currentPath = Directory.GetCurrentDirectory();
            var pathWithName = currentPath + "\\recipe.html";
            var headlineRecipe = "<h1><u> Recepie for " + _name + "</u></h1>";
            const string headlineMeds = "<h2><u>Medications:</u></h2>";
            const string headProcedures = "<h2><u>Procedures:</u></h2>";
            var listOfMeds = "";

            if (_recipe.Count != 0)
            {
                listOfMeds += "<ul>";
                listOfMeds = _recipe.Aggregate(listOfMeds, (current, t) => current + ("<li>" + t + "</li>"));
                listOfMeds += "</ul>";
                File.WriteAllText(pathWithName, headlineRecipe + headlineMeds + listOfMeds + headProcedures + lblProced.Text);

            }
            else
            {
                File.WriteAllText(pathWithName, headlineRecipe + headProcedures + lblProced.Text);
            }
            var preview = new Recipe(pathWithName);
            preview.ShowDialog();
        }





        private void brnClear_Click(object sender, EventArgs e)
        {
            tBoxDiseaseSearch.Clear();
            ClearConrols();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
