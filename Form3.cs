using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp3
{
    public partial class Form3 : Form
    {
        public Compte cp = new Compte();
        public Form3()
        {
            InitializeComponent();
        }

        private void valid_Click(object sender, EventArgs e)
        {
            if (numero!=null)
                cp.numero_Compte=numero.Text;
            if (titulaire!=null)
                cp.titulaire_Compte=titulaire.Text;
            if (solde != null)
                cp.solde_Compte = Convert.ToDouble(solde.Text);
        }
    }
}
