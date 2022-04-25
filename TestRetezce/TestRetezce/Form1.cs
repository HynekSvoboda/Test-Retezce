using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestRetezce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string vstup = textBox1.Text;
            char pismeno = 'a';
            while(vstup.Contains("  "))
            {
                vstup=vstup.Replace("  ", " ");
            }
           string[] slova = vstup.Split(' ');
           int pocet = 0;
           int nejvetsi = 0;
           char nejvetsipis = ' ';
           while(pismeno!= '{')
           {
                pocet = 0;
                foreach (string znak in slova)
                {
                    if (vstup.Contains(pismeno))
                    {
                        pocet++;
                    }
                    else
                    {
                        listBox1.Items.Add(pismeno);
                        break;
                    }
                    if (pocet > nejvetsi)
                    {
                        nejvetsi = pocet;
                        nejvetsipis = pismeno;
                    }
                }
                pismeno++;
            }
            label2.Text = " Největší výskyt: " + nejvetsipis.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string jednopismeno = textBox2.Text;
            char pismeno =Convert.ToChar( jednopismeno);
            if (pismeno >= 97 && pismeno <= 122)
            {
                MessageBox.Show("Tvoje zvolené písmeno: " + pismeno, "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Zadal jsi něco jiného, příště si opravdu vybírej z nabídky :D","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
