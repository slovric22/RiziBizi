﻿using RiziBizi.Models;
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
            SetFormText();
            var narudžbe = NarudžbeRepository.GetNarudžbe();
            cboNarudžbe.DataSource = narudžbe;
        }
        private void SetFormText()
        {
            Text = recenzija.Naziv ;
        }

        private void cboNarudžbe_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentNarudžbe = cboNarudžbe.SelectedItem as Narudžbe;
            txtKomentar.Text = currentNarudžbe.Recenzija;
            txtUsername.Text = currentNarudžbe.Sastojci;
           
            numOcjena.Minimum = 0;
            numOcjena.Maximum = 4;
        }
    }

}