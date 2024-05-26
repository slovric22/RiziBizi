namespace RiziBizi
{
    partial class FrmCRUD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNarudžbe = new System.Windows.Forms.Label();
            this.cboNarudžbe = new System.Windows.Forms.ComboBox();
            this.lblId_Recenzije = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblOcjena = new System.Windows.Forms.Label();
            this.txtOcjena = new System.Windows.Forms.TextBox();
            this.lblKomentar = new System.Windows.Forms.Label();
            this.txtKomentar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNarudžbe
            // 
            this.lblNarudžbe.AutoSize = true;
            this.lblNarudžbe.Location = new System.Drawing.Point(12, 39);
            this.lblNarudžbe.Name = "lblNarudžbe";
            this.lblNarudžbe.Size = new System.Drawing.Size(53, 13);
            this.lblNarudžbe.TabIndex = 0;
            this.lblNarudžbe.Text = "Narudžbe";
            // 
            // cboNarudžbe
            // 
            this.cboNarudžbe.FormattingEnabled = true;
            this.cboNarudžbe.Location = new System.Drawing.Point(15, 55);
            this.cboNarudžbe.Name = "cboNarudžbe";
            this.cboNarudžbe.Size = new System.Drawing.Size(274, 21);
            this.cboNarudžbe.TabIndex = 1;
            // 
            // lblId_Recenzije
            // 
            this.lblId_Recenzije.AutoSize = true;
            this.lblId_Recenzije.Location = new System.Drawing.Point(15, 94);
            this.lblId_Recenzije.Name = "lblId_Recenzije";
            this.lblId_Recenzije.Size = new System.Drawing.Size(68, 13);
            this.lblId_Recenzije.TabIndex = 2;
            this.lblId_Recenzije.Text = "ID Recenzije";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(18, 111);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(271, 20);
            this.txtId.TabIndex = 3;
            // 
            // lblOcjena
            // 
            this.lblOcjena.AutoSize = true;
            this.lblOcjena.Location = new System.Drawing.Point(15, 149);
            this.lblOcjena.Name = "lblOcjena";
            this.lblOcjena.Size = new System.Drawing.Size(41, 13);
            this.lblOcjena.TabIndex = 4;
            this.lblOcjena.Text = "Ocjena";
            // 
            // txtOcjena
            // 
            this.txtOcjena.Location = new System.Drawing.Point(18, 166);
            this.txtOcjena.Name = "txtOcjena";
            this.txtOcjena.Size = new System.Drawing.Size(271, 20);
            this.txtOcjena.TabIndex = 5;
            // 
            // lblKomentar
            // 
            this.lblKomentar.AutoSize = true;
            this.lblKomentar.Location = new System.Drawing.Point(18, 211);
            this.lblKomentar.Name = "lblKomentar";
            this.lblKomentar.Size = new System.Drawing.Size(52, 13);
            this.lblKomentar.TabIndex = 6;
            this.lblKomentar.Text = "Komentar";
            // 
            // txtKomentar
            // 
            this.txtKomentar.Location = new System.Drawing.Point(21, 228);
            this.txtKomentar.Name = "txtKomentar";
            this.txtKomentar.Size = new System.Drawing.Size(268, 20);
            this.txtKomentar.TabIndex = 7;
            // 
            // FrmCRUD
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 341);
            this.Controls.Add(this.txtKomentar);
            this.Controls.Add(this.lblKomentar);
            this.Controls.Add(this.txtOcjena);
            this.Controls.Add(this.lblOcjena);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId_Recenzije);
            this.Controls.Add(this.cboNarudžbe);
            this.Controls.Add(this.lblNarudžbe);
            this.Name = "FrmCRUD";
            this.ShowIcon = false;
            this.Text = "CRUD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNarudžbe;
        private System.Windows.Forms.ComboBox cboNarudžbe;
        private System.Windows.Forms.Label lblId_Recenzije;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblOcjena;
        private System.Windows.Forms.TextBox txtOcjena;
        private System.Windows.Forms.Label lblKomentar;
        private System.Windows.Forms.TextBox txtKomentar;
    }
}