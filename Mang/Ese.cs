using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang
{
    class Ese : Uksus
    {
        private string nimi;//переменная 'nimi' которая находится в этом классе
        private int punktide_arv;//переменная 'punktide_arv' которая находится в этом классе

        public Ese(string nimi, int punktide_arv)
        {
            this.nimi = nimi;
            this.punktide_arv = punktide_arv;
        }
        public string info()//Метод который возращает новые данные 'nimi' в класс 'Uksus'
        { 
            return nimi; 
        }
        public int punktideArv()//Метод который возращает новые данные 'punktide_arv' в класс 'Uksus'
        {
            return punktide_arv;
        }
    }
}
