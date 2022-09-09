using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang
{
    class Ese : Entity
    {
        public string nimi;
        public int arv;

        public Ese(string nimi, int punktidearv)
        {
            this.nimi = nimi;
            this.arv = punktidearv;
        }

        public string info() 
        { 
            return nimi; 
        }
        public int punktidearv()
        {
            return arv;
        }
    }
}
