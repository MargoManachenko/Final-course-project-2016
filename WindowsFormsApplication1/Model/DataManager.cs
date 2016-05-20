using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace DoctorsHandBook.Model
{
    class DataManager<T>
    {
        public string _fileName;

        public DataManager(string file)
        {
            _fileName = file;
        }
        
        public List<T> Init()
        {
            List<T> collection = new List<T>();
            if (File.Exists(_fileName))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(List<T>));
                using (FileStream fs = new FileStream(_fileName, FileMode.Open))
                {
                    collection = (List<T>)formatter.Deserialize(fs);
                }
            }
            return collection;
        }

        public void Update(List<T> collection)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<T>));
            using (FileStream fs = new FileStream(_fileName, FileMode.Create))
            {
                formatter.Serialize(fs, collection);
            }
        }       
    }
}
