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

        Button mygtukasn = new Button();
        Button mygtukasz = new Button();
        Double sk1 = 0;
        Double sk2 = 0;
        bool k = false;
        bool j = false;
        private void b1_Click(object sender, EventArgs e)
        {
            mygtukasn = b1;
            sk(b1);
        }

        private void b2_Click(object sender, EventArgs e)
        {
            mygtukasn = b2;
            sk(mygtukasn);
        }

        private void b3_Click(object sender, EventArgs e)
        {
            mygtukasn = b3;
            sk(mygtukasn);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            mygtukasn = b4;
            sk(mygtukasn);
        }

        private void b5_Click(object sender, EventArgs e)
        {
            mygtukasn = b5;
            sk(mygtukasn);
        }

        private void b6_Click(object sender, EventArgs e)
        {
            mygtukasn = b6;
            sk(mygtukasn);
        }

        private void b7_Click(object sender, EventArgs e)
        {
            mygtukasn = b7;
            sk(mygtukasn);
        }

        private void b8_Click(object sender, EventArgs e)
        {
            mygtukasn = b8;
            sk(mygtukasn);
        }

        private void b9_Click(object sender, EventArgs e)
        {
            mygtukasn = b9;
            sk(mygtukasn);
        }

        private void b0_Click(object sender, EventArgs e)
        {            
                mygtukasn = b0;
                sk(mygtukasn);                        
        }

        private void bd_Click(object sender, EventArgs e)
        {
            mygtukasz = bd;
            zn(mygtukasz);
        }

        private void bp_Click(object sender, EventArgs e)
        {
            mygtukasz = bp;
            zn(mygtukasz);
        }

        private void bm_Click(object sender, EventArgs e)
        {
            mygtukasz = bm;
            zn(mygtukasz);
        }

        private void bdg_Click(object sender, EventArgs e)
        {
            mygtukasz = bdg;
            zn(mygtukasz);
        }

        private void bda_Click(object sender, EventArgs e)
        {
            mygtukasz = bda;
            zn(mygtukasz);
        }

        private void be_Click(object sender, EventArgs e)
        {
            mygtukasz = be;
            zn(mygtukasz);
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
        private void zn (Button x)
        {
            if (x.Text != "," & x.Text != "=")
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
                if (x.Text == "," & laukas.Text == "")
                {
                    laukas.Text = "0,";
                    veiksmas.Text = "0,";
                }
                else
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
            }
            else if (x.Text == "=")
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
    }
}
