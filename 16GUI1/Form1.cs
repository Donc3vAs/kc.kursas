using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16GUI1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(LbL.Text);
            //Mbox
        }

        private void Butt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var skaicius = Convert.ToInt32(prk.Text);
            var forma = new Form2(skaicius);
            forma.ShowDialog();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void alfa_Click(object sender, EventArgs e)
        {
            using (var forma = new Form3())
            {
                forma.ShowDialog();

                if (forma.DialogResult == DialogResult.OK)
                {
                    langelis.Text = forma.Tekstas;
                }
            }
        }
    }
}
