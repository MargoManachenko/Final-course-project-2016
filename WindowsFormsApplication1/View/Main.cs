using System;
using System.Threading;
using System.Windows.Forms;
using DoctorsHandBook.View;
using WindowsFormsApplication1.View;

namespace DoctorsHandBook
{
    public partial class Form1 : Form
    {
        private Thread th;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var form = new MedsControl();
            form.TopLevel = false;
            form.Visible = true;
            form.FormBorderStyle = FormBorderStyle.None;
            tabMedications.Controls.Add(form);

            var form2 = new DiseasesControl();
            form2.TopLevel = false;
            form2.FormBorderStyle = FormBorderStyle.None;
            form2.Visible = true;
            tabDiseases.Controls.Add(form2);

            var form3 = new Prescription();
            form3.TopLevel = false;
            form3.FormBorderStyle = FormBorderStyle.None;
            form3.Visible = true;
            tabPrescriptions.Controls.Add(form3);

        }
    }
}
