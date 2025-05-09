using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            if(cmbSuperHeroes.Text == "Superman")
            {

            } else if (cmbSuperHeroes.Text == "Batman")
            {

            } else if (cmbSuperHeroes.Text == "Wonder Woman")
            {

            }

      
        }

        private void frmSuperHeroes_Load(object sender, EventArgs e)
        {
            cmbSuperHeroes.Items.Add("Superman");
            cmbSuperHeroes.Items.Add("Batman");
            cmbSuperHeroes.Items.Add("Wonder Woman");
        }
    }
}
