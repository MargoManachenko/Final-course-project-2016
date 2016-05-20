using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorsHandBook.Model
{
    class DiseaseAdapter
    {
        public string Title { get; set; }
        public string Symptoms { get; set; }
        public string Procedures { get; set; }
        public string Treatment { get; set; }


        public DiseaseAdapter(string title, string symptoms, string procedures, string treatment)
        {
            Title = title;
            Symptoms = symptoms;
            Procedures = procedures;
            Treatment = treatment;
        }
        
    }
}
