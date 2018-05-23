using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_3_uzduot
{
    public interface IDarbuotojas
    {
        int ID { get; }
        string Vardas { get; }
        void DarbuotInfo();
    }
    public class Darbuotojas : IDarbuotojas
    {
        public int ID { get; }
        public string Vardas { get; }

        public Darbuotojas(int ID, string Vardas)
        {
            this.ID = ID;
            this.Vardas = Vardas;
        }

        [STAThread]
        public void DarbuotInfo()
        {
            
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            string path = null;
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                path = fbd.SelectedPath;
            }
            System.IO.StreamWriter write = new System.IO.StreamWriter(path+"\\out.txt", true);
            write.WriteLine("Vartotojo id" + ID);
            write.WriteLine("Vartotojo vardas" + Vardas);
            write.Flush();
        }

    }
}
