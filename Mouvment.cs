using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp3
{
    internal class Mouvment
    {
        private DateTime dateop;
        private double montant;
        private string typop;

       

        public DateTime Dateop
        {
            get{ return dateop; }
            set{ dateop = value; }
        }

        public double Montant
        {
            get { return montant; }
            set { montant = value; }
        }

        public string Typop
        {
            get { return typop; }
            set { typop = value; }
        }
        public Mouvment(DateTime dateop, double montant, string typop)
        {
            Dateop = dateop;
            Montant = montant;
            Typop = typop;
        }

    }
}
