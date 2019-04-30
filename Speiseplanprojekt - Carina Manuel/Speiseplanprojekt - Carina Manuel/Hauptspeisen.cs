using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speiseplanprojekt___Carina_Manuel
{
    class Hauptspeisen : Speisen
    {
        private bool kinder;
        private string zusatz;
        private string fleisch;
        private bool veg;

        private static int anzahl;

        public Hauptspeisen(string SID, string speisenart, string name, string wk) : base(SID, speisenart, name, wk)
        {
            anzahl++;
        }
        public Hauptspeisen(string SID, string speisenart, string name, string wk, string zusatz, bool veg, bool kinder, string fleisch) : base(SID, speisenart, name, wk)
        {
            this.kinder = kinder;
            this.zusatz = zusatz;
            this.veg = veg;
            this.fleisch = fleisch;

            anzahl++;
        }

        public bool Kinder
        {
            get { return kinder; }
            set { kinder = value; }
        }

        public string Fleisch
        {
            get { return fleisch; }
            set { fleisch = value; }
        }

        public bool Veg
        {
            get { return veg; }
            set { veg = value; }
        }

        public string Zusatz
        {
            get { return zusatz; }
            set { zusatz = value; }
        }

        public override string ToString()
        {
            return base.ToString() + "\t" + kinder + ": \t" + note;
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
