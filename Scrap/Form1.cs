using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scrap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var url = textBox1.Text;
            GautiHTML(url);
            textBox1.Text = "";
            
        }
        private static async void GautiHTML(string url)
        {
            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);
            var htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.LoadHtml(html);
            /*
            var produktuSarasas = htmlDocument.DocumentNode.Descendants("ul")
                .Where(x => x.GetAttributeValue("class", "")
                .Equals("list")).ToList();
            foreach (var HtmlNode in produktuSarasas)
            {
                MessageBox.Show(HtmlNode.InnerText);
            }*/


            
            var produktuSarasas = htmlDocument.DocumentNode.Descendants("ul")
                .Where(x => x.GetAttributeValue("class", "")
                .Equals("list")).ToList();
        
            foreach (var HtmlNode in produktuSarasas)
            {
                var produktuElementai = HtmlNode.Descendants("li")
            .Where(x => x.GetAttributeValue("", "")
            .Contains("")).ToList();

                foreach (var Htm in produktuElementai)
                {
                    MessageBox.Show(Htm.InnerText);
                }
                    
            }
        }
    }
}
