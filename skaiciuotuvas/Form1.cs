using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace skaiciuotuvas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Double sk1 = 0;
        Double sk2 = 0;
        bool k = false;
        bool j = false;
        private void b1_Click(object sender, EventArgs e)
        {
            sk(b1);
        }

        private void b2_Click(object sender, EventArgs e)
        {
            sk(b2);
        }

        private void b3_Click(object sender, EventArgs e)
        {
            sk(b3);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            sk(b4);
        }

        private void b5_Click(object sender, EventArgs e)
        {
            sk(b5);
        }

        private void b6_Click(object sender, EventArgs e)
        {
            sk(b6);
        }

        private void b7_Click(object sender, EventArgs e)
        {
            sk(b7);
        }

        private void b8_Click(object sender, EventArgs e)
        {
            sk(b8);
        }

        private void b9_Click(object sender, EventArgs e)
        {
            sk(b9);
        }

        private void b0_Click(object sender, EventArgs e)
        {
            sk(b0);
        }

        private void bd_Click(object sender, EventArgs e)
        {
            zn(bd);
        }

        private void bp_Click(object sender, EventArgs e)
        {
            zn(bp);
        }

        private void bm_Click(object sender, EventArgs e)
        {
            zn(bm);
        }

        private void bdg_Click(object sender, EventArgs e)
        {
            zn(bdg);
        }

        private void bda_Click(object sender, EventArgs e)
        {
            zn(bda);
        }

        private void be_Click(object sender, EventArgs e)
        {
            zn(be);
        }


        // skaiciai
        private void sk(Button x)
        {
            if (k)
            {
                laukas.Text = null;
                k = false;
            }
            if (x.Text == "0" & laukas.Text == "")
            {
                laukas.Text = "0,";
                veiksmas.Text = "0,";
            }
            else
            {
                laukas.Text += x.Text;
                veiksmas.Text += x.Text;
            }
        }

        // zenklai
        private void zn(Button x)
        {
            if (veiksmas.Text == ""|| !char.IsNumber(veiksmas.Text[veiksmas.Text.Length-1])) { }
            else if (x.Text != "," & x.Text != "=")
            {
                if (laukas.Text == veiksmas.Text)
                {
                    veiksmas.Text += x.Text;
                    sk1 = Convert.ToDouble(laukas.Text);
                    laukas.Text = null;
                }
                else
                {
                    sk2 = Convert.ToDouble(laukas.Text);
                    sk1 = vk(sk1, sk2, veiksmas.Text[veiksmas.Text.Length - laukas.Text.Length - 1]);
                    laukas.Text = Convert.ToString(sk1);
                    veiksmas.Text += x.Text;
                    k = true;
                }
            }
            else if (x.Text == ",")
            {                
                    foreach (var n in laukas.Text)
                    {
                        if (n == ',')
                        {
                            j = true;
                        }
                    }
                    if (!j)
                    {
                        veiksmas.Text += x.Text;
                        laukas.Text += x.Text;
                        j = false;
                    }
            }
            else if (x.Text == "=" & veiksmas.Text[veiksmas.Text.Length - laukas.Text.Length - 1] != '=')
            {
                sk2 = Convert.ToDouble(laukas.Text);
                sk1 = vk(sk1, sk2, veiksmas.Text[veiksmas.Text.Length - laukas.Text.Length - 1]);
                laukas.Text = Convert.ToString(sk1);
                veiksmas.Text += x.Text + laukas.Text;
            }
        }
        private Double vk(double x, double y, char z)
        {
            if (z == '+') { x += y; }
            else if (z == '-') { x -= y; }
            else if (z == '*') { x *= y; }
            else if (z == '/') { x /= y; }
            return x;
        }

        private void bce_Click(object sender, EventArgs e)
        {
            Double sk1 = 0;
            Double sk2 = 0;
            bool k = false;
            bool j = false;
            veiksmas.Text = null;
            laukas.Text = null;
        }
    }
}
