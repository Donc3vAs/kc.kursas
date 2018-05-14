using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teleloto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int[][] bilietas = new int[4][];
            bilietas[0] = new int[4];
            bilietas[1] = new int[4];
            bilietas[2] = new int[4];
            bilietas[3] = new int[4];


            for (int y = 0; y < 4; y++)
            {                
                for (int i = 0; i < 4; i++)
                {
                    bilietas[y][i] = rnd.Next(y*10+1, y*10+11);
                    MessageBox.Show(Convert.ToString(bilietas[y][i]));
                }                
            }
        }
        
        

    }
}
