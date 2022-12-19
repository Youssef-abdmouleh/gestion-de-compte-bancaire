using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp3
{
    internal class Compte
    {
        private List<Mouvment> lmouv;
        private string numcompte;
        private double solde;
        private string titulaire;


        public List<Mouvment> mouvments
        {
            get { return lmouv; }
            set { lmouv = value; }
        }

        public string numero_Compte
        {
            get { return numcompte; }
            set { numcompte = value; }
        }
        public double solde_Compte
        {
            get { return solde; }
            set { solde = value; }
        }
        public string titulaire_Compte
        {
            get { return titulaire; }
            set { titulaire = value; }
        }
        public void compte()
        {
            lmouv  = new List<Mouvment>();
        }
        public void compte(string num, string titu, double sol)
        {
            num = numero_Compte;
            sol = solde_Compte;
            titu = titulaire_Compte;
        }
        public int NbMouv()
        {
            return lmouv.Count;
        }
        public void nouveauMouv( Mouvment m)
        {
            lmouv.Add(m);
        }
        public void retirer (double val)
        {
            solde -= val;

        }
        public void verser(double val)
        {
            solde += val;

        }



    }
}
