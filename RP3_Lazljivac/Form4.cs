using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RP3_Lazljivac
{
    public partial class Form4 : Form
    {
        private int ticks;
        public string ime;
        public List<Karta> spilKarata;
        public List<Karta> karteNaStolu;
        public string pocetnaBoja;
        private List<Igrac> igraci;
        private Karta trenutnaKarta;
        private int trenutniIgrac;
        private string brojKarata;
        public int B;
        public bool gotovRed;
        private List<string> boje = new List<string> { "srce", "karo", "pik", "tref" };
        public Form4(string _brojKarata)
        {
            InitializeComponent();
            spilKarata = new List<Karta>();
            karteNaStolu = new List<Karta>();
            igraci = new List<Igrac>();
            brojKarata = _brojKarata;
            if (brojKarata.Equals("32"))
            {
                for (int i = 1; i <= 8; i++)
                {
                    Karta karo = new Karta("karo", "karo (" + i.ToString() + ").png");
                    Karta srce = new Karta("srce", "srce (" + i.ToString() + ").png");
                    Karta pik = new Karta("pik", "pik (" + i.ToString() + ").png");
                    Karta tref = new Karta("tref", "tref (" + i.ToString() + ").png");
                    spilKarata.Add(karo);
                    spilKarata.Add(srce);
                    spilKarata.Add(pik);
                    spilKarata.Add(tref);
                }
            }
            else
            {
                for (int i = 1; i <= 13; i++)
                {
                    Karta karo = new Karta("karo", "karo (" + i.ToString() + ").png");
                    Karta srce = new Karta("srce", "srce (" + i.ToString() + ").png");
                    Karta pik = new Karta("pik", "pik (" + i.ToString() + ").png");
                    Karta tref = new Karta("tref", "tref (" + i.ToString() + ").png");
                    spilKarata.Add(karo);
                    spilKarata.Add(srce);
                    spilKarata.Add(pik);
                    spilKarata.Add(tref);
                }
            }
            gotovRed = false;
            pocetnaBoja = "";
            label4.Text = "Boja = " + pocetnaBoja;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //updateLabele();
            label1.Hide();
            label2.Hide();
            label6.Hide();
            label10.Hide();
            label11.Hide();
            label3.Hide();
            label4.Hide();
            label7.Hide();
            label8.Hide();
            button_otkrij.Hide();
            //timer1.Start();
        }


        private void dijeli()
        {
            Random random = new Random();

            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < B; ++i)
                {
                    int r1 = random.Next(0, spilKarata.Count - 1);
                    igraci[i].DodajKartu(spilKarata[r1]);
                    spilKarata.RemoveAt(r1);
                }
            }
            //timer1.Start();

        }

        private void button_dijeli_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                B = int.Parse(textBox1.Text);

                if (B == 1)
                {
                    this.Close();
                    Form2 druga = new Form2("Nepoznato", brojKarata);
                    druga.ShowDialog();

                }
                if (B > 5)
                {
                    MessageBox.Show("Broj igrača mora biti manji od 6");
                }
                else
                {
                    button3.Show();
                    
                    button_dalje.Visible = true;
                    pictureBox5.Show();
                    pictureBox6.Show();
                    pictureBox7.Show();
                    label5.Show();
                    // button_dalje.Show();
                    button_otkrij.Show();
                    label_trenutni.Show();
                 
                    pictureBox1.Show();
                    pictureBox2.Show();
                 
                    button_dijeli.Hide();

                    for (int i = 1; i <= B; ++i)
                    {
                        igraci.Add(new Igrac("Igrač " + i.ToString()));
                    }

                    Random random = new Random();
                    trenutniIgrac = random.Next(0, B);

                    label_trenutni.Text = "Trenutno na redu:";
                    dijeli();
                    button_otkrij.Hide();
                    label_br_ig.Hide();
                    if (igraci.Count > 0) label1.Show();
                    if (igraci.Count > 1) label2.Show();
                    if (igraci.Count > 2) label6.Show();
                    if (igraci.Count > 3) label10.Show();
                    if (igraci.Count > 4) label11.Show();
                    label3.Show();
                    label4.Show();
                    label7.Show();
                    label8.Show();
                    textBox1.Hide();
                    pictureBox5.Image = igraci[trenutniIgrac].ListaKarata[0].Image;
                    trenutnaKarta = igraci[trenutniIgrac].ListaKarata[0];
                    updateLabele();
                    timer1.Start();
                }
            }
            catch (FormatException )
            {
                MessageBox.Show("Unesite broj igrača!");
            }



        }

        

     

        private void button_dalje_Click(object sender, EventArgs e)
        {
            if (gotovRed)
            {
                //if (trenutniIgrac < (B - 1))
                //{
                //    trenutniIgrac++;
                //}
                //else
                //{
                //    trenutniIgrac = 0;
                //}
                if (karteNaStolu.Count > 0)
                {
                    button_otkrij.Show();
                }
                pictureBox2.Hide();
                pictureBox5.Enabled = true;
                trenutnaKarta = igraci[trenutniIgrac].ListaKarata[0];
                pictureBox5.Image = trenutnaKarta.Image;
                gotovRed = false;
                updateLabele();
                pictureBox5.Show();
            }

        }

        private void button_otkrij_Click(object sender, EventArgs e)
        {
            button_otkrij.Hide();
            pictureBox2.Show();
            if (karteNaStolu[karteNaStolu.Count - 1].Boja.Equals(pocetnaBoja))
            {
                foreach (Karta k in karteNaStolu)
                {
                    igraci[trenutniIgrac].DodajKartu(k);
                }
                karteNaStolu.Clear();
                pocetnaBoja = "";
            }
            else
            {
                if (trenutniIgrac > 0)
                {
                    --trenutniIgrac;
                }
                else
                {
                    trenutniIgrac = B - 1;
                }
                foreach (Karta k in karteNaStolu)
                {
                    igraci[trenutniIgrac].DodajKartu(k);
                }
                karteNaStolu.Clear();
                pocetnaBoja = "";
                gotovRed = true;
                pictureBox5.Hide();
                button_otkrij.Hide();
                updateLabele();
                return;
            };
            gotovRed = true;
            pictureBox5.Hide();
            button_otkrij.Hide();
            updateLabele();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            this.Text = ticks.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            zavrsiIgru();
        }

        private void pictureBox7_MouseClick(object sender, MouseEventArgs e)
        {
            int indeksTrenutne = igraci[trenutniIgrac].ListaKarata.IndexOf(trenutnaKarta);
            if (indeksTrenutne < igraci[trenutniIgrac].ListaKarata.Count - 1)
            {
                pictureBox5.Image = igraci[trenutniIgrac].ListaKarata[indeksTrenutne + 1].Image;
                trenutnaKarta = igraci[trenutniIgrac].ListaKarata[indeksTrenutne + 1];

            }
            else
            {
                pictureBox5.Image = igraci[trenutniIgrac].ListaKarata[0].Image;
                trenutnaKarta = igraci[trenutniIgrac].ListaKarata[0];
            }
        }

        private void pictureBox6_MouseClick(object sender, MouseEventArgs e)
        {
            int indeksTrenutne = igraci[trenutniIgrac].ListaKarata.IndexOf(trenutnaKarta);
            if (indeksTrenutne > 0)
            {
                pictureBox5.Image = igraci[trenutniIgrac].ListaKarata[indeksTrenutne - 1].Image;
                trenutnaKarta = igraci[trenutniIgrac].ListaKarata[indeksTrenutne - 1];

            }
            else
            {
                pictureBox5.Image = igraci[trenutniIgrac].ListaKarata[igraci[trenutniIgrac].ListaKarata.Count - 1].Image;
                trenutnaKarta = igraci[trenutniIgrac].ListaKarata[igraci[trenutniIgrac].ListaKarata.Count - 1];

            }
        }

        private void zavrsiIgru()
        {
            string pobjednik = igraci[trenutniIgrac].Ime;



            //SqlConnection sqlcon = new SqlConnection(@"Data Source=Lubar;Initial Catalog=Lazljivac;Integrated Security=True");

            //string query1 = "Insert into [Igra] (ID, Trajanje, Pobjednik) values (1," + ticks.ToString() + ", '" + pobjednik + "')";
            //SqlDataAdapter sda1 = new SqlDataAdapter(query1, sqlcon);
            //DataTable dtbl1 = new DataTable();

            //sda1.Fill(dtbl1);
            MessageBox.Show("Igra je gotova! Pobjednik je " + pobjednik);
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            updateLabele();

            if (karteNaStolu.Count == 0)
            {
                PopUp p = new PopUp();
                p.ShowDialog();
                if (p.boja != null) pocetnaBoja = p.boja;
                else return;
            }
            pictureBox2.Image = trenutnaKarta.Image;
            //prebacuje kartu koju je igrač bacio na stol
            karteNaStolu.Add(trenutnaKarta);
            //uklanju kartu koju je igrač bacio
            igraci[trenutniIgrac].BaciKartu(trenutnaKarta);

            if (igraci[trenutniIgrac].ListaKarata.Count > 0)
            {
                pictureBox5.Image = igraci[trenutniIgrac].ListaKarata[0].Image;
                trenutnaKarta = igraci[trenutniIgrac].ListaKarata[0];
            }
            else
            {
                string name = igraci[trenutniIgrac].Ime;

                MessageBox.Show("Igra je gotova! Pobjednik je " + name);
                this.Close();
            }
            // Igrač dobiva novu kartu iz špila
            Random random = new Random();
            int ran = random.Next(0, spilKarata.Count);

            if (spilKarata.Count > 0)
            {
                igraci[trenutniIgrac].DodajKartu(spilKarata[ran]);
                spilKarata.RemoveAt(ran);
            }

            if (igraci[trenutniIgrac].ListaKarata.Count == 0)
            {
                
            }

            if (trenutniIgrac < (B - 1))
            {
                trenutniIgrac++;
            }
            else
            {
                trenutniIgrac = 0;
            }
            pictureBox2.Hide();
            gotovRed = true;
            pictureBox5.Hide();
            button_otkrij.Hide();
            updateLabele();

        }
        public void updateLabele()
        {
            if (igraci.Count > 0) label1.Text = "Igrač 1 ima " + igraci[0].ListaKarata.Count + " karata";
            if (igraci.Count > 1) label2.Text = "Igrač 2 ima " + igraci[1].ListaKarata.Count + " karata";
            if (igraci.Count > 2) label6.Text = "Igrač 3 ima " + igraci[2].ListaKarata.Count + " karata";
            if (igraci.Count > 3) label10.Text = "Igrač 4 ima " + igraci[3].ListaKarata.Count + " karata";
            if (igraci.Count > 4) label11.Text = "Igrač 5 ima " + igraci[4].ListaKarata.Count + " karata";
            label3.Text = igraci[trenutniIgrac].Ime;
            label4.Text = "Boja: " + pocetnaBoja;
            label5.Text = "Broj karata: " + igraci[trenutniIgrac].ListaKarata.Count;
            label7.Text = "Broj karata u spilu: " + spilKarata.Count;
            label8.Text = "Broj karata na stolu: " + karteNaStolu.Count;
        }

        private void label_trenutni_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }  
}
