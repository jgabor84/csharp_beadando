using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beadando
{
    public partial class Form1 : Form
    {
        BitArray bitek1 = new BitArray(20);
        BitArray bitek2 = new BitArray(20);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chkboxCsoport1();
            chkboxCsoport2();


        }
        private void chkboxCsoport1()
        {
            CheckBox box;
            for (int i = 0; i < 20; i++)
            {
                box = new CheckBox();
                box.Tag = i.ToString();
                box.Text = i.ToString();
                box.AutoSize = true;
                if (i < 10)
                {
                    box.Location = new Point(10, i * 30);
                    panel1.Controls.Add(box);
                }
                else
                {
                    box.Location = new Point(80, (i - 10) * 30);
                    panel1.Controls.Add(box);
                }


            }
        }

        private void chkboxCsoport2()
        {
            CheckBox box;
            for (int i = 0; i < 20; i++)
            {
                box = new CheckBox();
                box.Tag = i.ToString();
                box.Text = i.ToString();
                box.AutoSize = true;
                if (i < 10)
                {
                    box.Location = new Point(10, i * 30);
                    panel2.Controls.Add(box);
                }
                else
                {
                    box.Location = new Point(80, (i - 10) * 30);
                    panel2.Controls.Add(box);
                }


            }
        }

   


        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "1. Bitarray: \n";
            label2.Text = "2. Bitarray: \n";
            int index = 0;
            foreach (Control c in panel1.Controls)
            {
                if ((c is CheckBox) && ((CheckBox)c).Checked)
                {
                    bitek1.Set(index, true);
                }
                else
                {
                    bitek1.Set(index, false);
                }
                index++;
            }


            int index2 = 0;
            foreach (Control c in panel2.Controls)
            {
                if ((c is CheckBox) && ((CheckBox)c).Checked)
                {
                    bitek2.Set(index2, true);
                }
                else
                {
                    bitek2.Set(index2, false);
                }
                index2++;
            }



            int sor = 0;
            foreach (bool i in bitek1)
            {
                label1.Text += "Bit " + sor + ": "+ i +" \n";
                sor++;
            }

            int sor2 = 0;
            foreach (bool i in bitek2)
            {
                label2.Text += "Bit " + sor2 + ": " + i + " \n";
                sor2++;
            }

        }


    }
}
