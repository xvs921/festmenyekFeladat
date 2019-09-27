using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Festmeny
    {
        string cim;
        string festo;
        public string Festo { get { return festo; } }
        string stilus;
        public string Stilus { get { return stilus; } }
        int licitekSzama;
        public int LicitekSzama { get { return licitekSzama; } }
        int legmagasabbLicit;
        public int LegmagasabbLicit { get { return legmagasabbLicit; } }
        DateTime legmagasabbLicitIdeje;
        public DateTime LegmagasabbLicitIdeje
        {
            get { return legmagasabbLicitIdeje; }
            set { legmagasabbLicitIdeje = value; }
        }
        bool elkelt;
        public bool Elkelt {
            get { return elkelt; }
            set { elkelt = value; }
        }

        int kezdetiLicit = 100;

        public Festmeny(string cim, string festo, string stilus)
        {
            this.cim = cim;
            this.festo = festo;
            this.stilus = stilus;
            this.licitekSzama = 0;
            this.legmagasabbLicit = 0;
            elkelt = false;
        }
        public void Licit()
        {
            if (elkelt==true)
            {
                Console.WriteLine("Hiba! A festmény elkelt!");
            }
            else if (licitekSzama==0)
            {
                legmagasabbLicit = kezdetiLicit;
                licitekSzama++;
                legmagasabbLicitIdeje = DateTime.Now;// állítsa be a legutolsó licit idejét az aktuális időpontra.

            }
            else if (licitekSzama > 0)
            {
                legmagasabbLicit=(legmagasabbLicit/10)*11;
                licitekSzama++;
                legmagasabbLicitIdeje = DateTime.Now;// állítsa be a legutolsó licit idejét az aktuális időpontra.
            }
        }
        public void Licit(int mertek)
        {
            legmagasabbLicit = (legmagasabbLicit / 10) * 11;
            licitekSzama++;
            legmagasabbLicitIdeje = DateTime.Now;
        }

    }
}
