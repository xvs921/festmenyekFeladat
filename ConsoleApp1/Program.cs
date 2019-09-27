using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static List<Festmeny> festmenyLista = new List<Festmeny>();
        static void Main(string[] args)
        {
            
            festmenyLista.Add(new Festmeny("sadasd","dfsdfs","dfsdf"));
            festmenyLista.Add(new Festmeny("sadasd", "dfsdfs", "dfsdf"));
            Console.WriteLine("Adjon meg egy számot");
            int mennyi = int.Parse(Console.ReadLine());
            //bekérés
            for (int i = 0; i < mennyi; i++)
            {
                Console.WriteLine("Adja meg címét!");
                string cim = Console.ReadLine();
                Console.WriteLine("Adja meg festőt!");
                string festo = Console.ReadLine();
                Console.WriteLine("Adja meg stílusát!");
                string stilus = Console.ReadLine();
                festmenyLista.Add(new Festmeny(cim, festo, stilus));
            }
            //20 gépi licit
            for (int i = 0; i < 20; i++)
            {
                Random random = new Random();
                int rnd = random.Next(0, festmenyLista.Count);
                
            }
            //felhasználó licit
            

            
        }
    }
}
