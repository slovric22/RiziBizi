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
using RiziBizi;

namespace RiziBizi
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == " " || password == " ")
            {
                MessageBox.Show("Popunite sva polja!", "Pogreška!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (username == "admin" && password == "test")
            {
                Hide();
                frmRecenzije frmRecenzije = new frmRecenzije();
                frmRecenzije.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Korisničko ime ili lozinka nisu ispravni!", "Pogreška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
