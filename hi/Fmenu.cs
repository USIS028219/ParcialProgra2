using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Torres_Anibal_Parcial
{
    public partial class Fmenu : Form
    {
        public Fmenu()
        {
            InitializeComponent();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FClientes cambio = new FClientes();
            this.Hide();
            cambio.ShowDialog();
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FPeliculas cambio = new FPeliculas();
            this.Hide();
            cambio.ShowDialog();
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            FAlquiler cambio = new FAlquiler();
            this.Hide();
            cambio.ShowDialog();
            this.Close();
        }
    }
}
