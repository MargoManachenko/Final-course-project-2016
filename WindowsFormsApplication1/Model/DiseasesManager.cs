using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Serialization;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DHB.Model;

namespace DoctorsHandBook.Model
{
    internal class DiseasesManager
    {
        private List<Disease> _diseases;
        private const string DiseaseFileName = "diseases.xml";
        private readonly DataManager<Disease> _dataManager = new DataManager<Disease>(DiseaseFileName);
        private List<RecipeMaker> _recipeMaker;

        public DiseasesManager()
        {
            _diseases = new List<Disease>();
        }

        //индексатор,позволяющий получать объект типа Disease по индексу
        public Disease this[int position] => _diseases[position];

        //метод для заполнения DataGridView
        public List<DiseaseAdapter> GetDisiases()
        {
            List<DiseaseAdapter> collection = new List<DiseaseAdapter>();

            foreach (var dis in _diseases)
            {
                string treatment = "";
                for (int i = 0; i < dis.Treatment.Count(); i++)
                {
                    if (dis.Treatment.Count - 1 != i)
                    {
                        treatment += dis.Treatment[i] + "\n, ";
                    }
                    else
                    {
                        treatment += dis.Treatment[i] + "\n";
                    }
                }
                DiseaseAdapter disease = new DiseaseAdapter(dis.Title, dis.Symptoms, dis.Procedures, treatment);
                collection.Add(disease);
            }
            return collection;
        }

        //метод добавления в коллекцию
        public void Add(Disease disease)
        {
            _diseases.Add(disease);
        }

        //получение из xml
        public void Init()
        {
            _diseases = _dataManager.Init();
        }

        //запись в xml 
        public void Update()
        {
            _dataManager.Update(_diseases);
        }

        //метод удаления из коллекции
        public void Delete(string selectedDis)
        {
            for (int i = 0; i < _diseases.Count; i++)
            {
                if (selectedDis != _diseases[i].Title) continue;
                _diseases.Remove(_diseases[i]);
                break;
            }
        }

        //метод редактирования
        public void Edit(Disease oldDis, Disease newDis)
        {
            for (var i = 0; i < _diseases.Count; i++)
            {
                if (_diseases[i].Title != oldDis.Title) continue;
                _diseases[i] = newDis;
                break;
            }
        }

        //метод получения списка всех лекарств от данного заболевания
        public RecipeMaker GetTreatment(string title)
        {
            return (from disease in _diseases where string.Equals(disease.Title, title, StringComparison.CurrentCultureIgnoreCase) select new RecipeMaker(disease.Treatment, disease.Procedures, disease.Title)).FirstOrDefault();
        }
    }
}
