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
        protected string zusatz;
        protected string fleischart;
        protected string veg;
        protected string wk;
        protected string kinderspeise;

        public Speisen(string SID, string speisenart,  string name, string zusatz, string fleischart, string veg, string wk, string kinderspeise)
        {
            this.sID = SID;
            this.speisenart = speisenart;
            this.name = name;
            this.zusatz = zusatz;
            this.fleischart = fleischart;
            this.veg = veg;
            this.wk = wk;
            this.kinderspeise = kinderspeise;
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

        public string Zusatz
        {
            get { return zusatz; }
            set { zusatz = value; }
        }
        public string Fleischart
        {
            get { return fleischart; }
            set { fleischart = value; }
        }

        public string Veg
        {
            get { return veg; }
            set { veg = value; }
        }

        public string WK
        {
            get { return wk; }
            set { wk = value; }
        }
        public string Kinderspeise
        {
            get { return kinderspeise; }
            set { kinderspeise = value; }
        }

        public override string ToString()
        {
            return sID + "\t" + speisenart + "\t"  + name + "\t\t" + zusatz + "\t"+fleischart + "\t" + "\t" + veg + "\t\t" + wk + "\t" + kinderspeise;
        }
    }
}
