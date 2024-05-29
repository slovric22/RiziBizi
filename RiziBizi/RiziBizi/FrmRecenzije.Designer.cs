namespace RiziBizi
{
    partial class frmRecenzije
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
            this.dgvRecenzije = new System.Windows.Forms.DataGridView();
            this.btnCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecenzije)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRecenzije
            // 
            this.dgvRecenzije.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRecenzije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecenzije.Location = new System.Drawing.Point(20, 24);
            this.dgvRecenzije.Name = "dgvRecenzije";
            this.dgvRecenzije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecenzije.Size = new System.Drawing.Size(746, 284);
            this.dgvRecenzije.TabIndex = 0;
            this.dgvRecenzije.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecenzije_CellContentClick);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(33, 354);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(103, 48);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Dodaj recenziju";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // frmRecenzije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dgvRecenzije);
            this.Name = "frmRecenzije";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recenzije";
            this.Load += new System.EventHandler(this.FrmRecenzije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecenzije)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dgvRecenzije;
    private System.Windows.Forms.Button btnCreate;
}
}