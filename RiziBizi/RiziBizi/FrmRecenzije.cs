using RiziBizi.Models;
using RiziBizi.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBLayer;

namespace RiziBizi
{
    public partial class frmRecenzije : Form
    {
        public frmRecenzije()
        {
            InitializeComponent();
        }

        private void FrmRecenzije_Load(object sender, EventArgs e)
        {
            ShowRecenzije();
        }
        private void ShowRecenzije()
        {
            List<Recenzija> recenzije = RecenzijaRepository.GetRecenzija();
            dgvRecenzije.DataSource = recenzije;

            dgvRecenzije.Columns["Id"].DisplayIndex = 0;
            dgvRecenzije.Columns["Ocjena"].DisplayIndex = 1;
            dgvRecenzije.Columns["Komentar"].DisplayIndex = 2;
            dgvRecenzije.Columns["Username"].DisplayIndex = 3;
            dgvRecenzije.Columns["Narudžbe"].DisplayIndex = 4;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Recenzija selectedRecenzija = dgvRecenzije.CurrentRow.DataBoundItem as Recenzija;
            if (selectedRecenzija != null)
            {
                FrmCRUD frmCRUD = new FrmCRUD(selectedRecenzija);
                frmCRUD.ShowDialog();
            }

        }

        private void dgvRecenzije_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}