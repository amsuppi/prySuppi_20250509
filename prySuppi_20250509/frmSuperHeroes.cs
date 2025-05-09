using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prySuppi_20250509.Properties;

namespace prySuppi_20250509
{
    public partial class frmSuperHeroes : Form
    {
        public frmSuperHeroes()
        {
            InitializeComponent();
        }

        private void cmbSuperHeroes_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cmbSuperHeroes.Text)
            {
                case "Superman":
                    pbxSuperHeroes.Image = Resources.Superman1;
                    break;
                case "Batman":
                    pbxSuperHeroes.Image = Resources.batman;
                    break;
                case "Wonder Woman":
                    pbxSuperHeroes.Image = Resources.wonderWoman;
                    break;
                default:
                    break;
            }

      
        }

        private void frmSuperHeroes_Load(object sender, EventArgs e)
        {
            cmbSuperHeroes.Items.Add("Superman");
            cmbSuperHeroes.Items.Add("Batman");
            cmbSuperHeroes.Items.Add("Wonder Woman");

            nudFuerza.Maximum = 10;
            nudFuerza.Minimum = 0;

            nudDestreza.Minimum = 0;
            nudDestreza.Maximum = 10;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            using (StreamWriter streamWriter = new StreamWriter("Super_heroes.txt", true))
            {
                streamWriter.WriteLine("Fuerza: " + nudFuerza.Value.ToString() +
                                       " Destreza: " + nudDestreza.Value.ToString());

                MessageBox.Show("Datos guardados correctamente")M
            }

        }
    }
}
