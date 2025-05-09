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
            this.bpbStats = new System.Windows.Forms.GroupBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.nudFuerza = new System.Windows.Forms.NumericUpDown();
            this.nudDestreza = new System.Windows.Forms.NumericUpDown();
            this.lblFuerza = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSuperHeroes)).BeginInit();
            this.bpbStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFuerza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDestreza)).BeginInit();
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
            this.pbxSuperHeroes.Location = new System.Drawing.Point(34, 83);
            this.pbxSuperHeroes.Name = "pbxSuperHeroes";
            this.pbxSuperHeroes.Size = new System.Drawing.Size(437, 275);
            this.pbxSuperHeroes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSuperHeroes.TabIndex = 2;
            this.pbxSuperHeroes.TabStop = false;
            // 
            // bpbStats
            // 
            this.bpbStats.Controls.Add(this.label2);
            this.bpbStats.Controls.Add(this.lblFuerza);
            this.bpbStats.Controls.Add(this.nudDestreza);
            this.bpbStats.Controls.Add(this.nudFuerza);
            this.bpbStats.Controls.Add(this.btnCrear);
            this.bpbStats.Location = new System.Drawing.Point(34, 374);
            this.bpbStats.Name = "bpbStats";
            this.bpbStats.Size = new System.Drawing.Size(437, 100);
            this.bpbStats.TabIndex = 3;
            this.bpbStats.TabStop = false;
            this.bpbStats.Text = "Stats";
            this.bpbStats.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(356, 71);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // nudFuerza
            // 
            this.nudFuerza.Location = new System.Drawing.Point(158, 19);
            this.nudFuerza.Name = "nudFuerza";
            this.nudFuerza.Size = new System.Drawing.Size(120, 20);
            this.nudFuerza.TabIndex = 1;
            // 
            // nudDestreza
            // 
            this.nudDestreza.Location = new System.Drawing.Point(158, 61);
            this.nudDestreza.Name = "nudDestreza";
            this.nudDestreza.Size = new System.Drawing.Size(120, 20);
            this.nudDestreza.TabIndex = 2;
            // 
            // lblFuerza
            // 
            this.lblFuerza.AutoSize = true;
            this.lblFuerza.Location = new System.Drawing.Point(7, 25);
            this.lblFuerza.Name = "lblFuerza";
            this.lblFuerza.Size = new System.Drawing.Size(39, 13);
            this.lblFuerza.TabIndex = 3;
            this.lblFuerza.Text = "Fuerza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Destreza";
            // 
            // frmSuperHeroes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 525);
            this.Controls.Add(this.bpbStats);
            this.Controls.Add(this.pbxSuperHeroes);
            this.Controls.Add(this.lblHeroes);
            this.Controls.Add(this.cmbSuperHeroes);
            this.Name = "frmSuperHeroes";
            this.Text = "Super Heroes";
            this.Load += new System.EventHandler(this.frmSuperHeroes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSuperHeroes)).EndInit();
            this.bpbStats.ResumeLayout(false);
            this.bpbStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFuerza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDestreza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSuperHeroes;
        private System.Windows.Forms.Label lblHeroes;
        private System.Windows.Forms.PictureBox pbxSuperHeroes;
        private System.Windows.Forms.GroupBox bpbStats;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFuerza;
        private System.Windows.Forms.NumericUpDown nudDestreza;
        private System.Windows.Forms.NumericUpDown nudFuerza;
        private System.Windows.Forms.Button btnCrear;
    }
}

