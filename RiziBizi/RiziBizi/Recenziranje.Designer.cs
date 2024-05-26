namespace RiziBizi
{
    partial class FrmRecenziranje
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
            this.cboNarudžba = new System.Windows.Forms.ComboBox();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.txtMinGrade = new System.Windows.Forms.TextBox();
            this.txtMaxGrade = new System.Windows.Forms.TextBox();
            this.txtOpisNarudžbe = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.numPoints = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNarudžba
            // 
            this.lblNarudžba.AutoSize = true;
            this.lblNarudžba.Location = new System.Drawing.Point(32, 32);
            this.lblNarudžba.Name = "lblNarudžba";
            this.lblNarudžba.Size = new System.Drawing.Size(53, 13);
            this.lblNarudžba.TabIndex = 0;
            this.lblNarudžba.Text = "Narudžba";
            // 
            // cboNarudžba
            // 
            this.cboNarudžba.FormattingEnabled = true;
            this.cboNarudžba.Location = new System.Drawing.Point(35, 60);
            this.cboNarudžba.Name = "cboNarudžba";
            this.cboNarudžba.Size = new System.Drawing.Size(181, 21);
            this.cboNarudžba.TabIndex = 1;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(331, 32);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(92, 13);
            this.lblMin.TabIndex = 2;
            this.lblMin.Text = "Minimalna ocjena:";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(483, 32);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(101, 13);
            this.lblMax.TabIndex = 3;
            this.lblMax.Text = "Maksimalna ocjena:";
            // 
            // txtMinGrade
            // 
            this.txtMinGrade.Location = new System.Drawing.Point(334, 60);
            this.txtMinGrade.Name = "txtMinGrade";
            this.txtMinGrade.Size = new System.Drawing.Size(100, 20);
            this.txtMinGrade.TabIndex = 4;
            // 
            // txtMaxGrade
            // 
            this.txtMaxGrade.Location = new System.Drawing.Point(486, 60);
            this.txtMaxGrade.Name = "txtMaxGrade";
            this.txtMaxGrade.Size = new System.Drawing.Size(100, 20);
            this.txtMaxGrade.TabIndex = 5;
            // 
            // txtOpisNarudžbe
            // 
            this.txtOpisNarudžbe.Location = new System.Drawing.Point(35, 101);
            this.txtOpisNarudžbe.Multiline = true;
            this.txtOpisNarudžbe.Name = "txtOpisNarudžbe";
            this.txtOpisNarudžbe.Size = new System.Drawing.Size(549, 150);
            this.txtOpisNarudžbe.TabIndex = 6;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(257, 254);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(47, 13);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "Korisnik:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(401, 254);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(86, 13);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Datum recenzije:";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(542, 254);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(44, 13);
            this.lblGrade.TabIndex = 9;
            this.lblGrade.Text = "Ocjena:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(260, 270);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 10;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(404, 270);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 20);
            this.txtDate.TabIndex = 11;
            // 
            // numPoints
            // 
            this.numPoints.Location = new System.Drawing.Point(545, 270);
            this.numPoints.Name = "numPoints";
            this.numPoints.Size = new System.Drawing.Size(71, 20);
            this.numPoints.TabIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(394, 320);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 35);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(524, 320);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 33);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FrmRecenziranje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 367);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numPoints);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtOpisNarudžbe);
            this.Controls.Add(this.txtMaxGrade);
            this.Controls.Add(this.txtMinGrade);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.cboNarudžba);
            this.Controls.Add(this.lblNarudžba);
            this.Name = "FrmRecenziranje";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recenziranje";
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNarudžba;
        private System.Windows.Forms.ComboBox cboNarudžba;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.TextBox txtMinGrade;
        private System.Windows.Forms.TextBox txtMaxGrade;
        private System.Windows.Forms.TextBox txtOpisNarudžbe;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.NumericUpDown numPoints;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}