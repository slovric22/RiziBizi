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
            this.btnOdustani = new System.Windows.Forms.Button();
            this.txtOcjena = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNarudžbe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNarudžba
            // 
            this.lblNarudžba.AutoSize = true;
            this.lblNarudžba.Location = new System.Drawing.Point(12, 90);
            this.lblNarudžba.Name = "lblNarudžba";
            this.lblNarudžba.Size = new System.Drawing.Size(56, 13);
            this.lblNarudžba.TabIndex = 0;
            this.lblNarudžba.Text = "Narudžba:";
            // 
            // lblOcjena
            // 
            this.lblOcjena.AutoSize = true;
            this.lblOcjena.Location = new System.Drawing.Point(9, 313);
            this.lblOcjena.Name = "lblOcjena";
            this.lblOcjena.Size = new System.Drawing.Size(44, 13);
            this.lblOcjena.TabIndex = 4;
            this.lblOcjena.Text = "Ocjena:";
            // 
            // lblKomentar
            // 
            this.lblKomentar.AutoSize = true;
            this.lblKomentar.Location = new System.Drawing.Point(9, 139);
            this.lblKomentar.Name = "lblKomentar";
            this.lblKomentar.Size = new System.Drawing.Size(55, 13);
            this.lblKomentar.TabIndex = 6;
            this.lblKomentar.Text = "Komentar:";
            // 
            // txtKomentar
            // 
            this.txtKomentar.Location = new System.Drawing.Point(12, 155);
            this.txtKomentar.Multiline = true;
            this.txtKomentar.Name = "txtKomentar";
            this.txtKomentar.Size = new System.Drawing.Size(267, 92);
            this.txtKomentar.TabIndex = 7;
            this.txtKomentar.TextChanged += new System.EventHandler(this.txtKomentar_TextChanged);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(12, 375);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(103, 50);
            this.btnSpremi.TabIndex = 8;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(12, 260);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(78, 13);
            this.lblUsername.TabIndex = 9;
            this.lblUsername.Text = "Korisničko ime:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(12, 276);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(267, 20);
            this.txtUsername.TabIndex = 10;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(234, 375);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(100, 50);
            this.btnOdustani.TabIndex = 13;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // txtOcjena
            // 
            this.txtOcjena.Location = new System.Drawing.Point(12, 330);
            this.txtOcjena.Name = "txtOcjena";
            this.txtOcjena.Size = new System.Drawing.Size(100, 20);
            this.txtOcjena.TabIndex = 14;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 23);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 15;
            this.lblId.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(15, 40);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(97, 20);
            this.txtId.TabIndex = 16;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // txtNarudžbe
            // 
            this.txtNarudžbe.Location = new System.Drawing.Point(15, 107);
            this.txtNarudžbe.Name = "txtNarudžbe";
            this.txtNarudžbe.Size = new System.Drawing.Size(264, 20);
            this.txtNarudžbe.TabIndex = 17;
            // 
            // FrmCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 450);
            this.Controls.Add(this.txtNarudžbe);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtOcjena);
            this.Controls.Add(this.btnOdustani);
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
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.TextBox txtOcjena;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNarudžbe;
    }
}