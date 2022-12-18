using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp5;

namespace Projet
{
    public partial class Form2 : Form
    {
        string currentCmd;
        public Form2(string id_client, string id_commande, DateTime dateCmd, string title)
        {
            InitializeComponent();
            Connection.insertCommande(id_client, id_commande, dateCmd);
            currentCmd = id_commande;
            gridViewsLoad();
            lblTitle.Font = new Font("Century Gothic", 18);
            lblTitle.Text = title;
            lblTitle.SetBounds(150, -200, 3, 0);
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gvPlatAtt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string search = tbSearch.Text;
            gvPlats.DataSource = Connection.findPlat(search);
        }

        private void gvPlats_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbQte_TextChanged(object sender, EventArgs e)
        {

        }
        public void gridViewsLoad()
        {
            gvPlatAtt.DataSource = Connection.getAllPlat(currentCmd);
            gvPlats.DataSource = Connection.getAllPlat();
        }
        private void btnAddPlat_Click(object sender, EventArgs e)
        {
            string plat_id, qte;
            plat_id = gvPlats.SelectedCells[0].Value.ToString();
            qte = tbQte.Text;
            try
            {
                Connection.insertPlatCmd(currentCmd, plat_id, qte);
                lblError.Text = string.Empty;
                tbSearch.Text = string.Empty;
            }
            catch (Exception)
            {

                lblError.Text = "la quantité demandé est non disponible";
            }

            gridViewsLoad();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
