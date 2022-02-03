using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies.Domain
{
    public abstract class DomainItem
    {
        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        public void SetItem()
        {

        }
        public DomainItem GetItem(int id)
        {
            return null;
        }
        

    }
}
