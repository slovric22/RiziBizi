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
            this.lblNarudžba = new System.Windows.Forms.Label();
            this.lblOcjena = new System.Windows.Forms.Label();
            this.lblKomentar = new System.Windows.Forms.Label();
            this.txtKomentar = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.cboNarudžbe = new System.Windows.Forms.ComboBox();
            this.numOcjena = new System.Windows.Forms.NumericUpDown();
            this.btnOdustani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numOcjena)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNarudžba
            // 
            this.lblNarudžba.AutoSize = true;
            this.lblNarudžba.Location = new System.Drawing.Point(19, 46);
            this.lblNarudžba.Name = "lblNarudžba";
            this.lblNarudžba.Size = new System.Drawing.Size(56, 13);
            this.lblNarudžba.TabIndex = 0;
            this.lblNarudžba.Text = "Narudžba:";
            // 
            // lblOcjena
            // 
            this.lblOcjena.AutoSize = true;
            this.lblOcjena.Location = new System.Drawing.Point(19, 293);
            this.lblOcjena.Name = "lblOcjena";
            this.lblOcjena.Size = new System.Drawing.Size(44, 13);
            this.lblOcjena.TabIndex = 4;
            this.lblOcjena.Text = "Ocjena:";
            // 
            // lblKomentar
            // 
            this.lblKomentar.AutoSize = true;
            this.lblKomentar.Location = new System.Drawing.Point(19, 107);
            this.lblKomentar.Name = "lblKomentar";
            this.lblKomentar.Size = new System.Drawing.Size(55, 13);
            this.lblKomentar.TabIndex = 6;
            this.lblKomentar.Text = "Komentar:";
            // 
            // txtKomentar
            // 
            this.txtKomentar.Location = new System.Drawing.Point(12, 123);
            this.txtKomentar.Multiline = true;
            this.txtKomentar.Name = "txtKomentar";
            this.txtKomentar.Size = new System.Drawing.Size(267, 92);
            this.txtKomentar.TabIndex = 7;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(12, 393);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(103, 32);
            this.btnSpremi.TabIndex = 8;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(19, 240);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(78, 13);
            this.lblUsername.TabIndex = 9;
            this.lblUsername.Text = "Korisničko ime:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(12, 256);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(267, 20);
            this.txtUsername.TabIndex = 10;
            // 
            // cboNarudžbe
            // 
            this.cboNarudžbe.FormattingEnabled = true;
            this.cboNarudžbe.Location = new System.Drawing.Point(12, 62);
            this.cboNarudžbe.Name = "cboNarudžbe";
            this.cboNarudžbe.Size = new System.Drawing.Size(267, 21);
            this.cboNarudžbe.TabIndex = 11;
            this.cboNarudžbe.SelectedIndexChanged += new System.EventHandler(this.cboNarudžbe_SelectedIndexChanged);
            // 
            // numOcjena
            // 
            this.numOcjena.Location = new System.Drawing.Point(12, 309);
            this.numOcjena.Name = "numOcjena";
            this.numOcjena.Size = new System.Drawing.Size(85, 20);
            this.numOcjena.TabIndex = 12;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(231, 393);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(103, 32);
            this.btnOdustani.TabIndex = 13;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // FrmCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 450);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.numOcjena);
            this.Controls.Add(this.cboNarudžbe);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.txtKomentar);
            this.Controls.Add(this.lblKomentar);
            this.Controls.Add(this.lblOcjena);
            this.Controls.Add(this.lblNarudžba);
            this.Name = "FrmCRUD";
            this.ShowIcon = false;
            this.Text = "Recenzije";
            ((System.ComponentModel.ISupportInitialize)(this.numOcjena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNarudžba;
        private System.Windows.Forms.Label lblOcjena;
        private System.Windows.Forms.Label lblKomentar;
        private System.Windows.Forms.TextBox txtKomentar;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.ComboBox cboNarudžbe;
        private System.Windows.Forms.NumericUpDown numOcjena;
        private System.Windows.Forms.Button btnOdustani;
    }
}