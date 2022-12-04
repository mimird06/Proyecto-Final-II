using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsPlantNaville
{
    public partial class PlantNaville : Form
    {
        public PlantNaville()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       //Funcionabilidad de la barra de tiempo en el Splash
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            label2.Text = progressBar1.Value.ToString() + "%";

            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                this.Hide();
                Login frmlogin = new Login();
                frmlogin.ShowDialog();
            }
        }

        private void PlantNaville_Load(object sender, EventArgs e)
        {

        }
    }
}
