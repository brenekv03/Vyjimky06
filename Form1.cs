using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vyjimky06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream("text.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                int sc = 0;
                while(!sr.EndOfStream)
                {
                    try
                    {
                        sc +=int.Parse(sr.ReadLine());
                    }
                    catch(FormatException)
                    {
                        //cislo neni cele
                    }
                    catch(OverflowException)
                    {
                        // moc velke nebo male
                    }
                }
            }
            catch(FileNotFoundException)
            {
                File.Create("text.txt");
            }
        }
    }
}
