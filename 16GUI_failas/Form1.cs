using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16GUI_failas
{
    public partial class Form1 : Form
    {
        public List<Auto> AutoL { get; } 
        public Form1()
        {
            InitializeComponent();
            AutoL = new List<Auto>();
        }

        private void iseitiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void failasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void atidarytiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var failas = new OpenFileDialog())
            {
                failas.Filter = "csv failas (*.csv)|*.csv";
                failas.InitialDirectory = "c:\\";
                //failas.ShowDialog();
                if (failas.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var tekstas = File.ReadAllLines(failas.FileName);
                        foreach (var eilute in tekstas)
                        {
                            //MessageBox.Show(eilute);
                            //var auto = new Auto(eilute);
                            AutoL.Add(new Auto(eilute));
                        }
                        dataGridView1.DataSource = AutoL;
                        
                        //dataGridView1.Columns["Priority"].SortMode = DataGridViewColumnSortMode.Automatic;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    }
                    //MessageBox.Show(failas.FileName);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1.DataSource = AutoL.Select(s => new { ID = s.StudentId, RUDE = s.RUDE, Nombre = s.Name, Apellidos = s.LastNameFather + " " + s.LastNameMother, Nacido = s.DateOfBirth })
            //                       .OrderBy(s => s.Apellidos)
            //                       .ToList();

            dataGridView1.DataSource = AutoL.Select(s => new { marke = s.Marke, modelis = s.Modelis, metai = s.Metai })
                                  .OrderBy(s => s.marke)
                                  .ToList();

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {

                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }
    }
}
