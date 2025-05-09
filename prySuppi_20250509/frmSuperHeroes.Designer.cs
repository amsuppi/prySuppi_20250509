namespace prySuppi_20250509
{
    partial class frmSuperHeroes
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbSuperHeroes = new System.Windows.Forms.ComboBox();
            this.lblHeroes = new System.Windows.Forms.Label();
            this.pbxSuperHeroes = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSuperHeroes)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSuperHeroes
            // 
            this.cmbSuperHeroes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSuperHeroes.FormattingEnabled = true;
            this.cmbSuperHeroes.Location = new System.Drawing.Point(34, 44);
            this.cmbSuperHeroes.Name = "cmbSuperHeroes";
            this.cmbSuperHeroes.Size = new System.Drawing.Size(437, 21);
            this.cmbSuperHeroes.TabIndex = 0;
            this.cmbSuperHeroes.SelectedIndexChanged += new System.EventHandler(this.cmbSuperHeroes_SelectedIndexChanged);
            // 
            // lblHeroes
            // 
            this.lblHeroes.AutoSize = true;
            this.lblHeroes.Location = new System.Drawing.Point(31, 28);
            this.lblHeroes.Name = "lblHeroes";
            this.lblHeroes.Size = new System.Drawing.Size(72, 13);
            this.lblHeroes.TabIndex = 1;
            this.lblHeroes.Text = "Super Heroes";
            // 
            // pbxSuperHeroes
            // 
            this.pbxSuperHeroes.Location = new System.Drawing.Point(34, 114);
            this.pbxSuperHeroes.Name = "pbxSuperHeroes";
            this.pbxSuperHeroes.Size = new System.Drawing.Size(437, 275);
            this.pbxSuperHeroes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSuperHeroes.TabIndex = 2;
            this.pbxSuperHeroes.TabStop = false;
            // 
            // frmSuperHeroes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 419);
            this.Controls.Add(this.pbxSuperHeroes);
            this.Controls.Add(this.lblHeroes);
            this.Controls.Add(this.cmbSuperHeroes);
            this.Name = "frmSuperHeroes";
            this.Text = "Super Heroes";
            this.Load += new System.EventHandler(this.frmSuperHeroes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSuperHeroes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSuperHeroes;
        private System.Windows.Forms.Label lblHeroes;
        private System.Windows.Forms.PictureBox pbxSuperHeroes;
    }
}

