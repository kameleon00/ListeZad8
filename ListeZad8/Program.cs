using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListeZad8
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> gradovi = new Dictionary<string, int>()
            {
                {"Beograd", 2000000},
                {"Nis", 1400000 },
                {"Kraljevo", 400000 }
            };

            Console.WriteLine("Pre dodavanja elemenata");
            foreach (KeyValuePair<string, int> grad in gradovi)
                Console.WriteLine(grad.Key + " - " + grad.Value);
            Console.WriteLine("=======================================");

            //dodavanje metodom Add()
            gradovi.Add("Novi Sad", 600000);

            //dodavanje preko indeksera
            gradovi["Kragujevac"] = 300000;

            //modifikovanje preko indeksera
            gradovi["Beograd"] = 1800000; // posle korone hehe

            Console.WriteLine("Posle dodavanja");
            foreach (KeyValuePair<string, int> grad in gradovi)
                Console.WriteLine(grad.Key + " - " + grad.Value);
            Console.WriteLine("=======================================");

            Console.ReadLine();
        }
    }
}
