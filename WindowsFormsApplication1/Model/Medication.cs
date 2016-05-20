using System;

namespace DoctorsHandBook.Model
{
    [Serializable]
    public class Medication
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int DoseUnit { get; set; }
        public int DosePortion { get; set; }
        public int DosePeriod { get; set; }       
        public int QuantityInStock { get; set; }

        public Medication() { }

        public Medication(string title, string description, int doseUnit, int dosePortion, int dosePeriod, int qinstock)
        {
            Title = title;
            Description = description;
            DoseUnit = doseUnit;
            DosePortion = dosePortion;
            DosePeriod = dosePeriod;
            QuantityInStock = qinstock;
        }

     }
}
