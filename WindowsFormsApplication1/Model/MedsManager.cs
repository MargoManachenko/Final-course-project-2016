using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Data;
using System.Linq;

namespace DoctorsHandBook.Model
{
    public class MedsManager
    {
        private List<Medication> _meds;
        private const string MedsFileName = "med.xml";
        private readonly DataManager<Medication> _dataManager = new DataManager<Medication>(MedsFileName);

        public MedsManager()
        {
            _meds = new List<Medication>();
        }

        //доступ к полю _meds для заполнения DataGridView
        public List<Medication> GetMeds()
        {
            return _meds;
        }

        //индексатор, дает информацию о наличии медикамента на складе
        public bool this[string med]
        {
            get
            { return _meds.Any(unit => med == unit.Title && unit.QuantityInStock != 0); }
        }

        public List<int> GetStock()
        {
            return _meds.Select(med => med.QuantityInStock).ToList();
        }

        //метод добавления в коллекцию
        public void AddMed(Medication med)
        {
            _meds.Add(med);
        }

        //метод удаления из коллекции
        public void Delete(string selectedMed)
        {
            for (var i = 0; i < _meds.Count; i++)
            {
                if (selectedMed != _meds[i].Title) continue;
                _meds.Remove(_meds[i]);
                break;
            }
        }

        //получение из xml
        public void Init()
        {
            _meds = _dataManager.Init();
        }

        //запись в xml 
        public void Update()
        {
            _dataManager.Update(_meds);
        }

        //метод редактирования
        public void Edit(Medication oldMed, Medication newMed)
        {
            for (var i = 0; i < _meds.Count; i++)
            {
                if (_meds[i].Title != oldMed.Title) continue;
                _meds[i] = newMed;
                break;
            }
        }
    }
}
