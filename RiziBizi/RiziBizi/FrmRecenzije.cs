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

          
        }

    }
}
