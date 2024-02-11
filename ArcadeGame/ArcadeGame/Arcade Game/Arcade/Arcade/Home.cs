using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atestat_caro
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            joctablaculori f = new joctablaculori();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XsiO f = new XsiO();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flappybirdgame f = new flappybirdgame();
            f.Show();
        }
    }
}
