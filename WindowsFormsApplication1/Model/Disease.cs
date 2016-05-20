using System;
using System.Collections.Generic;

namespace DoctorsHandBook.Model
{
    [Serializable]
    public class Disease
    {
        public string Title { get; set; }
        public string Symptoms { get; set; }
        public string Procedures { get; set; }
        public List<string> Treatment { get; set; }

        public Disease() { }

        public Disease(string title, string symptoms, string procedures, List<string> treatment)
        {
            Title = title;
            Symptoms = symptoms;
            Procedures = procedures;
            Treatment = treatment;
        }
    }

    

}
