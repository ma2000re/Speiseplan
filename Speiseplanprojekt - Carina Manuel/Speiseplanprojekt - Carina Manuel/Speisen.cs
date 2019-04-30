using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speiseplanprojekt___Carina_Manuel
{
    public class Speisen
    {
        protected string sID;
        protected string speisenart;
        protected string name;
        protected string wk;

        private static int anzahl;

        public Speisen(string SID, string speisenart,  string name, string wk)
        {
            this.sID = SID;
            this.speisenart = speisenart;
            this.name = name;
            this.wk = wk;
        }

        public string SID
        {
            get { return sID; }
            set { sID = value; }
        }

        public string Speisenart
        {
            get { return speisenart; }
            set { speisenart = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string WK
        {
            get { return wk; }
            set { wk = value; }
        }

        public override string ToString()
        {
            return sID + "\t" + speisenart + "\t"  + name + "\t" + wk;
        }
        
        public static int getAnzahl()
        {
            return anzahl;
        }
        public static void setAnzahlMinusEins()
        {
            anzahl--;
        }
    }
}
