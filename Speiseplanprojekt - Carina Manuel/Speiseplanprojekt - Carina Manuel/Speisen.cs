using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speiseplanprojekt___Carina_Manuel
{
    class Speisen
    {
        protected string sID;
        protected string name;
        protected string zusatz;
        protected string veg;
        protected string wk;

        public Speisen(string SID, string name, string zusatz, string veg, string wk)
        {
            this.sID = SID;
            this.name = name;
            this.zusatz = zusatz;
            this.veg = veg;
            this.wk = wk;
        }

        public string SID
        {
            get { return sID; }
            set { sID = value; }
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


    }
}
