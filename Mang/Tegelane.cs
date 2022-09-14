using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang
{
    class Tegelane : Uksus
    {
        private string nimi;
        private List<Ese> ese = new List<Ese>();        
        public int Esemed_arv;

        public Tegelane(string nimi)
        {
            this.nimi=nimi;
        }
        public int lisaEse(int lisa)
        {
            //this.lisa = lisa;
            return lisa;
        }
        public int punktideArv()
        {
            int punkti = 0;
            foreach (Ese item in ese)
            {
                punkti += item.punktideArv();
            }
            return punkti;
        }
        /*public bool Arvuta_esemed()
        {

            StreamReader lugeda = new StreamReader(@"..\..\..\Info_Koduloom.txt");
            string texta;
            while ((texta = lugeda.ReadLine()) != null)
            {
                string[] rida = texta.Split(',');
                //koera.Add(new Koer(rida[0], rida[1]));
            }
            lugeda.Close();
        }*/
        public void Info(/*int Esemed_arv*/)
        {
            string info = ($"Nimi mängija:{nimi}, Esemed:{Esemed_arv}, Punkti: {/*punkti*/punktideArv()}");
            Console.WriteLine(info);
        }
        public async Task valjastaEsemed()
        {
            /*StreamReader lugeda = new StreamReader(@"..\..\..\Info_Koduloom.txt");
            string texta;
            using (StreamReader reader = new StreamReader(path))
            {
                while ((texta = lugeda.ReadLine()) != null)
                {
                    string? line;
                    while ((line = await reader.ReadLineAsync()) != null)
                    {
                        Console.WriteLine(line);
                    }
                    //string[] rida = texta.Split(',');
                    //koera.Add(new Koer(rida[0], rida[1]));
                }
            }
            lugeda.Close();*/
            string path = "Esemed.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                string text = await reader.ReadToEndAsync();
                Console.WriteLine(text);
            }
        }

        public string info()
        {
            throw new NotImplementedException();
        }
    }
}
