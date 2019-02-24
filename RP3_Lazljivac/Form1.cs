using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RP3_Lazljivac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string igrac;


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                igrac = textBox1.Text;
            }
            else
            {
                igrac = "Nepoznato";
            }
           

            
            Form2 druga = new Form2(igrac, comboBox2.Text);
            druga.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 treca = new Form3();
            treca.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 cetvrta = new Form4(comboBox2.Text);
            cetvrta.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form4 cetvrta = new Form4(comboBox2.Text);
            cetvrta.ShowDialog();
        }
    }
}
