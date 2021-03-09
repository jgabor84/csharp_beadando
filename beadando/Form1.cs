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
        BitClass bc = new BitClass();

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
            label3.Text = "Eredmény: \n";

            checkbox1Ertek();
            checkbox2Ertek();
            kiir(bc.Bitek1, 1);
            kiir(bc.Bitek2, 2);


            if (radioButton1.Checked == true)
            {
                bc.szamolAnd();

            }
            else if (radioButton2.Checked == true)
            {
                bc.szamolOr();

            }
            else if (radioButton4.Checked == true)
            {
                bc.szamolClone();

            }
            else
            {
                bc.szamolXor();

            }
            kiir(bc.Eredmeny,3);


        }

        private void kiir(BitArray bitcsop, int label)
        {
            StringBuilder builder = new StringBuilder();

            int sor = 0;
            foreach (bool str in bitcsop)
            {
                builder.Append("Bit " + sor + ": " + str.ToString()).AppendLine();
                sor++;
            }
            if(label == 1) { 
                label1.Text += builder.ToString(); 
            }
            else if(label == 2){
                label2.Text += builder.ToString();
            }
            else
            {
                label3.Text += builder.ToString();
            }
            


        }

        private void checkbox1Ertek()
        {
            int index = 0;
            foreach (Control c in panel1.Controls)
            {
                if ((c is CheckBox) && ((CheckBox)c).Checked)
                {
                    bc.Bitek1.Set(index, true);
                }
                else
                {
                    bc.Bitek1.Set(index, false);
                }
                index++;
            }
        }
 

        private void checkbox2Ertek()
        {
            int index2 = 0;
            foreach (Control c2 in panel2.Controls)
            {
                if ((c2 is CheckBox) && ((CheckBox)c2).Checked)
                {
                    bc.Bitek2.Set(index2, true);
                }
                else
                {
                    bc.Bitek2.Set(index2, false);
                }
                index2++;
            }
        }





    }
}
