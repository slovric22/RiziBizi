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
using RiziBizi.Properties;

namespace RiziBizi
{
    public partial class FrmCRUD : Form
    {

        private Recenzija recenzija;
        private Narudžbe narudžbe;

       
        public FrmCRUD()
        {
            InitializeComponent();
        }

        
        public FrmCRUD(Recenzija selectedRecenzija)
        {
            InitializeComponent();
            recenzija = selectedRecenzija;
        }

        
        private void FrmCRUD_Load(object sender, EventArgs e)
        {
            SetFormText();
            var narudžbe = NarudžbeRepository.GetNarudžbe();
            cboNarudžbe.DataSource = narudžbe;

            if (recenzija != null)
            {
                txtId.Text = recenzija.Id.ToString();
                txtOcjena.Text = recenzija.Ocjena.ToString();
                txtKomentar.Text = recenzija.Komentar.ToString();
                
                cboNarudžbe.Text = recenzija.Narudžbe.ToString();
            }
        }

        
        private void SetFormText()
        {
            Text = (recenzija != null) ? recenzija.Ocjena + " " + recenzija.Komentar : "Unos recenzije";
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

       
        private void cboNarudžbe_SelectedIndexChanged(object sender, EventArgs e)
        {
            narudžbe = cboNarudžbe.SelectedItem as Narudžbe;
        }

       
        private void btnSave_Click(object sender, EventArgs e, string narudžbe)
        {
            if (txtOcjena.Text == "")
            {
                MessageBox.Show("Ocjena nije unesena!", "Problem", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else if (txtKomentar.Text == "")
            {
                MessageBox.Show("Komentar nije unesen!", "Problem", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                if (recenzija == null)
                {
                    recenzija = new Recenzija();
                }
                recenzija.Ocjena = txtOcjena.Text;
                recenzija.Komentar = txtKomentar.Text;
                
                recenzija.Narudžbe = narudžbe;
                RecenzijaRepository.SaveRecenzije(recenzija);
                Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
