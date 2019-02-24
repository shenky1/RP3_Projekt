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
    public partial class PopUp : Form
    {
        public PopUp()
        {
            InitializeComponent();
        }
        public string boja;

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            boja = "karo";
            this.Close();
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            boja = "srce";
            this.Close();
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            boja = "tref";
            this.Close();
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            boja = "pik";
            this.Close();
        }
    }
}
