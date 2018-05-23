using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20_2uzd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string line;
            System.IO.StreamReader reader = new System.IO.StreamReader(@"C:\Users\Donc3vas\source\repos\sharp_kursas\20_2uzd\bin\Debug\f1.txt");
            while ((line = reader.ReadLine()) != null)
            {
                comboBox1.Items.Add(line);
            }
            reader.Dispose();

        }
        List<concstr> UserList = new List<concstr>();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.IO.StreamReader reader = new System.IO.StreamReader(@"C:\Users\Donc3vas\source\repos\sharp_kursas\20_2uzd\bin\Debug\f2.txt");
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                try
                {
                    string[] data = line.Split(' ');

                    concstr user = new concstr(data[0], data[1], data[2],
                        new DateTime(
                            year: int.Parse(data[3]) / 10000,
                            month: int.Parse(data[3]) % 10000 / 100,
                            day: int.Parse(data[3]) % 100), int.Parse(data[4]), int.Parse(data[5]));
                    UserList.Add(user);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            reader.Dispose();

            foreach (var item in UserList)
            {
                if(item.UserID == comboBox1.SelectedItem.ToString())
                {
                    textBox1.Text = item.UserID;
                    textBox2.Text = item.Name;
                    textBox3.Text = item.Surname;
                    textBox4.Text = item.Dob.ToShortDateString();
                    textBox5.Text = item.Salary.ToString();
                    textBox6.Text = item.WorkYear.ToString();
                }
            }
        }
    }
}
