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
        string festo { get; }
        string stilus { get; }
        int licitekSzama { get; }
        int legmagasabbLicit { get; }
        DateTime legmagasabbLicitIdeje { get; set; }
        bool elkelt { get; set; }

        /*+Festmeny(cím : string, festo : string, stilus : string) 
         * +Festo {get;} : string +Stilus {get;} : string +LicitekSzama {get;} : int +LegmagasabbLicit {get;} : int 
         * +LegutolsoLicitIdeje {get;} : DateTime +Elkelt {get; set;} : bool +Licit() : void +Licit(mertek : int) : void*/
        public Festmeny(string cim, string festo, string stilus)
        {
            this.cim = cim;
            this.festo = festo;
            this.stilus = stilus;
        }


    }
}
