using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp3
{
    internal class listCompte
    {
        private List<Compte> LCompte;
        public listCompte()
        {
            LCompte = new List<Compte>();
        }

        public List<Compte> List_compte
        {
            get { return LCompte; }
            set { LCompte = value; }
            
        }
        public void Ajouter(Compte c)
        {
                LCompte.Add(c);
        }
        public Compte Rechercher (string num)
        {
            Compte compte = null;
            foreach (Compte c in LCompte)
            {
                if (c.numero_Compte == num)
                {
                    compte = c;
                    break;
                }             
            }
            return compte;

        }
        public void Supprimer(Compte c)
        {
            if (LCompte.Contains(c))
                LCompte.Remove(c);
        }
    }
}
