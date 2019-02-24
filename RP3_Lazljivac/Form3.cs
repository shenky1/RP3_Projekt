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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {



            // TODO: This line of code loads data into the 'lazljivacDataSet1.Igra' table. You can move, or remove it, as needed.
            this.igraTableAdapter.Fill(this.lazljivacDataSet1.Igra);
            // TODO: This line of code loads data into the 'lazljivacDataSet.Igra' table. You can move, or remove it, as needed.
            this.igraTableAdapter.Fill(this.lazljivacDataSet.Igra);
            // TODO: This line of code loads data into the 'lazljivacDataSet.Igra' table. You can move, or remove it, as needed.
            this.igraTableAdapter.Fill(this.lazljivacDataSet.Igra);
            // TODO: This line of code loads data into the 'lazljivacDataSet.Igra' table. You can move, or remove it, as needed.
            this.igraTableAdapter.Fill(this.lazljivacDataSet.Igra);

        }
    }
}
