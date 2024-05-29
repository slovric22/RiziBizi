using RiziBizi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RiziBizi.Repositories;
using System.Xml.Linq;
using RiziBizi.Properties;
using DBLayer;
using RiziBizi;
using System.Drawing.Text;
using System.Security.Cryptography;


namespace RiziBizi
{



    public partial class FrmCRUD : Form
    {
        private Recenzija recenzija;

        public void RefreshTable()
            {
            ShowRecenzije();

            }

        public FrmCRUD(Recenzija selectedRecenzija)
        {
            InitializeComponent();
            recenzija = selectedRecenzija;
        }


        private void btnSpremi_Click(object sender, EventArgs e)
        {
           
            

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void FrmCRUD_Load(object sender, EventArgs e)
        {
            ShowRecenzije();
           
        }

        private void ShowRecenzije()
        {
            List<Recenzija> recenzijas = RecenzijaRepository.GetRecenzija();
            
        }
        private void SetFormText()
        {
            Text = recenzija.Naziv + " " + recenzija.Id;
        }

       

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKomentar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
