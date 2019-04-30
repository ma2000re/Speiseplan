using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speiseplanprojekt___Carina_Manuel
{
    class Nachspeisen : Speisen
    {
        private string zusatz;

        private static int anzahl;

        public Nachspeisen(string SID, string speisenart, string name, string wk) : base(SID, speisenart, name, wk)
        {
            anzahl++;
        }

        public Nachspeisen(string SID, string speisenart, string name, string wk, string zusatz) : base(SID, speisenart, name, wk)
        {
            this.zusatz = zusatz;
            anzahl++;
        }

        public string Zusatz
        {
            get { return zusatz; }
            set { zusatz = value; }
        }
        public override string ToString()
        {
            return base.ToString() + "\t" + zusatz;
        }
        public static int Anzahl
        {
            get { return anzahl; }
        }
        public static void setAnzahlMinusEins()
        {
            anzahl--;
        }

    }
}
