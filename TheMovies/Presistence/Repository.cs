using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies.Presistence
{
    public class Repository
    {
        public List<IDomainItem> Items = new();


        public IDomainItem Get (int id)
        {
            return null;
        }

        public void Add (IDomainItem item)
        {

        }

        public void Remove(int id)
        {

        }
        

    }
}
