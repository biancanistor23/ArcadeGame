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
    public partial class joctablaculori : Form
    {
        Button[,] b;
        int contor_click = 0;
        public joctablaculori()
        {
            InitializeComponent();
            int i, j;
            b = new Button[4, 4];
            b[0, 0] = button1;
            b[0, 1] = button2;
            b[0, 2] = button3;
            b[0, 3] = button4;

            b[1, 0] = button5;
            b[1, 1] = button6;
            b[1, 2] = button7;
            b[1, 3] = button8;

            b[2, 0] = button9;
            b[2, 1] = button10;
            b[2, 2] = button11;
            b[2, 3] = button12;

            b[3, 0] = button13;
            b[3, 1] = button14;
            b[3, 2] = button15;
            b[3, 3] = button16;
            for (i = 0; i < 4; i++)
                for (j = 0; j < 4; j++)
                {
                    b[i, j].BackColor = Color.Orchid;
                    b[i, j].Click += new EventHandler(button_Click);
                }
            BackColor = Color.Azure;
        }
        private bool Gata()
        {
            int i, j;
            for (i = 0; i < 4; i++)
                for (j = 0; j < 4; j++)
                    if (b[i, j].BackColor == Color.Orchid)
                        return false;
            return true;
        }
        private void button_Click(object sender, EventArgs e)
        {
            int i, j;
            contor_click++;
            label1.Text =""+contor_click;
            for (i = 0; i < 4; i++)
                for (j = 0; j < 4; j++)
                {
                    if (b[i, j] == sender)
                    {
                        ChangeColor(b[i, j]);
                        if (i > 0) ChangeColor(b[i - 1, j]);
                        if (j > 0) ChangeColor(b[i, j - 1]);
                        if (i < 3) ChangeColor(b[i + 1, j]);
                        if (j < 3) ChangeColor(b[i, j + 1]);
                    }
                }
            if (Gata() == true)
            {
                MessageBox.Show("BRAVO, ai terminat din "+contor_click+" click-uri!");
                contor_click = 0;
                label1.Text = "" + contor_click;
                for (i = 0; i < 4; i++)
                    for (j = 0; j < 4; j++)
                    {
                        b[i, j].BackColor = Color.Orchid;
                    }
            }
        }
        private void ChangeColor(Button b)
        {
            if (b.BackColor == Color.Orchid)
                b.BackColor = Color.BlueViolet;
            else
                b.BackColor = Color.Orchid;
        }
        private void joctablaculori_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reset_Click(object sender, EventArgs e)
        {

            int i, j;
            contor_click = 0;
            label1.Text = "" + contor_click;
            for (i = 0; i < 4; i++)
                for (j = 0; j < 4; j++)
                {
                    b[i, j].BackColor = Color.Orchid;
                }
        }
    }
}
