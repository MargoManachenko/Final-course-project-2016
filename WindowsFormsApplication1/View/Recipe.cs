using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1.View
{
    public partial class Recipe : Form
    {

        //форма, выводящая сформированый рецепт в webbrowser

        private readonly string _adress;

        public Recipe(string adress)
        {
            _adress = adress;
            InitializeComponent();
        }
        //загрузка адресса

        private void Recipe_Load(object sender, EventArgs e)
        {
            webBrRecepie.Navigate(_adress);
        }


        //печать

        private void btnPrint_Click(object sender, EventArgs e)
        {
            webBrRecepie.Print();
        }


        //закрытие 

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
