using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace None
{
    public partial class SourceForm : Form
    {
        public SourceForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sourcePath = pathTxt.Text;
            string targetPathOfNewFolder = Path.GetDirectoryName(sourcePath) + @"\Out";
            string targetPath = targetPathOfNewFolder + @"\Summary.txt";


            try
            {
                Directory.CreateDirectory(targetPathOfNewFolder);

                string[] lines = File.ReadAllLines(sourcePath);

                List<SelledItem> selledIens = new List<SelledItem>();

                string name = "";
                double price = 0.0;
                int quantity = 0;

                foreach(string line in lines)
                {
                    ItemDatas.GetDatasOfItem(ref name, ref price, ref quantity, line);

                    selledIens.Add(new SelledItem(name, price, quantity));
                }

                using(StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (SelledItem selledItem in selledIens)
                        sw.WriteLine(selledItem);
                }

                MessageBox.Show("Operação feita com sucesso!");
            }
            catch(IOException error)
            {
                MessageBox.Show(error.Message, "An error occorred...");
            }

        }
    }
}
