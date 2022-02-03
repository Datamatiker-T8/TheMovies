using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheMovies.Domain;
using System.IO;

namespace TheMovies.Presistence
{
    public class DataHandler
    {
        public string path = "";
        private string fileName;

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        public IDomainItem LoadItem (DomainItem item)
        {
            
            if (item is Movie)
            {
                
            }
            return null;
        }

        public void SaveItem (int id)
        {

        }
        public List<IDomainItem> LoadItems()
        {
            List<IDomainItem> items = new List<IDomainItem>();
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    List<DomainItem> p = new();
                    string[] data = p.ToString().Split(';');
                    Cinema c = new(data[0]);
                    City cy = new(data[1]);
                    Movie me = new(data[3], data[4], TimeSpan.Parse(data[5]), data[6], DateTime.Parse(data[8]));
                    
                    foreach (DomainItem item in items)
                    {
                        items.Add(p);
                    }
                }
            }
            return items;
        }
        public void SaveItems(List<IDomainItem> items)
        {

        }



    }
}
