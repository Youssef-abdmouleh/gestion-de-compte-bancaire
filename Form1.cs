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
    public partial class Frm_Cpt : Form
    {

        public Frm_Cpt()
        {
            InitializeComponent();
        }

        public void afficher()
        {
            int index = dg_client.CurrentRow.Index;
            txt_num.Text = dg_client.[index][1].ToString();
            txt_titu.Text = dg_client.[index][2].ToString();
            txt_sol.Text = dg_client.[index][3].ToString();
        }



        listCompte lc = new listCompte();
        private void Ajou_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
            lc.Ajouter(f3.cp);
            dg_client.Rows.Add(f3.cp);
        }

        private void sup_Click(object sender, EventArgs e)
        {
            afficher();
            dg_client.SelectedRows.Clear();
        }
    }
}
