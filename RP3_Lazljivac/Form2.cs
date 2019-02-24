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
using System.Data.SqlClient;

namespace RP3_Lazljivac
{
    public partial class Form2 : Form
    {

        private int ticks;
        public string ime;
        public string brojKarata;
        public List<Karta> spilKarata;
        public List<Karta> karteNaStolu;
        public string pocetnaBoja;
        private Igrac igrac;
        private Igrac računalo;
        private Karta trenutnaKarta;
        private List<string> boje = new List<string> { "srce", "karo", "pik", "tref" };
        public Form2(string _ime, string _brojKarata)
        {
            InitializeComponent();
            ime = _ime;
            brojKarata = _brojKarata;
            spilKarata = new List<Karta>();
            karteNaStolu = new List<Karta>();
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
            } else
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


            igrac = new Igrac(ime);
            računalo = new Igrac("Računalo");
            dijeli();
            //prva karta iz liste karata igrača
            pictureBox5.Image = igrac.ListaKarata[0].Image;
            trenutnaKarta = igrac.ListaKarata[0];
            pocetnaBoja = "";
            label4.Text = "Boja = " + pocetnaBoja;
            Random random = new Random();
            if (random.Next(0, 2) > 0)
            {
                racunalo();
                pictureBox4.Show();
                pictureBox3.Hide();
            }
            else
            {
                pictureBox3.Show();
                pictureBox4.Hide();
            }
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            label3.Text = ime;
            updateLabele();
            timer1.Start();
        }
        private void dijeli()
        {
            Random random = new Random();


            for (int j = 0; j < 4; j++)
            {
                int r1 = random.Next(0, spilKarata.Count - 1);
                igrac.DodajKartu(spilKarata[r1]);
                spilKarata.RemoveAt(r1);
                int r2 = random.Next(0, spilKarata.Count - 1);
                računalo.DodajKartu(spilKarata[r2]);
                spilKarata.RemoveAt(r2);
            }


            ImageList listaKarata = new ImageList();
            foreach (Karta k in igrac.ListaKarata)
            {
                listaKarata.Images.Add(k.Image);
            }



        }


        private void button2_Click(object sender, EventArgs e)
        {
            button2.Hide();
            pictureBox1.Show();
            if (karteNaStolu[karteNaStolu.Count - 1].Boja.Equals(pocetnaBoja))
            {
                foreach (Karta k in karteNaStolu)
                {
                    igrac.DodajKartu(k);
                }
                karteNaStolu.Clear();
                pocetnaBoja = "";
                label10.Text = "Promašili ste. Računalo nije lagalo.";


            }
            else
            {
                foreach (Karta k in karteNaStolu)
                {
                    računalo.DodajKartu(k);
                }
                karteNaStolu.Clear();
                label10.Text = "Pogodili ste. Računalo je lagalo.";
                updateLabele();
                racunalo();
                return;
            };
            updateLabele();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (karteNaStolu.Count > 0)
            {
                button2.Show();
            }
            pictureBox1.Hide();
            pictureBox5.Enabled = true;
            pictureBox3.Show();
            pictureBox4.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            zavrsiIgru();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //    System.Diagnostics.Debug.WriteLine("Pocetak igracevog poteza: ");
            //    debug();
            if (karteNaStolu.Count == 0)
            {
                PopUp p = new PopUp();
                p.ShowDialog();
                if (p.boja != null) pocetnaBoja = p.boja;
                else return;
            }
            pictureBox1.Image = trenutnaKarta.Image;
            //prebacuje kartu koju je igrač bacio na stol
            karteNaStolu.Add(trenutnaKarta);
            //uklanju kartu koju je igrač bacio
            igrac.BaciKartu(trenutnaKarta);
           
            if (igrac.ListaKarata.Count > 0)
            {
                pictureBox5.Image = igrac.ListaKarata[0].Image;
                trenutnaKarta = igrac.ListaKarata[0];
            }
            else
            {
                //povezivanje baze i dodavanje novog pobjednika
                SqlConnection sqlcon = new SqlConnection(@"Data Source=Lubar;Initial Catalog=Lazljivac;Integrated Security=True");
                string name = igrac.Ime;
                string query1 = "Insert into [Igra] (ID, Trajanje, Pobjednik) values (1," + ticks.ToString() + ", '" + name + "')";
                SqlDataAdapter sda1 = new SqlDataAdapter(query1, sqlcon);
                DataTable dtbl1 = new DataTable();

                sda1.Fill(dtbl1);

                MessageBox.Show("Igra je gotova! Pobjednik je " + igrac.Ime);
                this.Close();
            }
            // Igrač dobiva novu kartu iz špila
            Random random = new Random();
            int ran = random.Next(0, spilKarata.Count);
            if(spilKarata.Count > 0)
            {
                igrac.DodajKartu(spilKarata[ran]);
                spilKarata.RemoveAt(ran);
            }

            if (igrac.ListaKarata.Count == 0)
            {
                zavrsiIgru();
            }

            pictureBox3.Hide();
            pictureBox4.Show();
            updateLabele();
            System.Diagnostics.Debug.WriteLine("Kraj igracevog poteza: ", igrac.ListaKarata);
            foreach (Karta k in igrac.ListaKarata)
            {
                System.Diagnostics.Debug.WriteLine(k.FileName);
            }
            System.Diagnostics.Debug.WriteLine("Karte na stolu: ");
            foreach (Karta k in karteNaStolu)
            {
                System.Diagnostics.Debug.WriteLine(k.FileName);
            }
            // Poziva računalo da odigra svoj red
            racunalo();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            this.Text = ticks.ToString();
        }

        public void racunalo()
        {
            //   System.Diagnostics.Debug.WriteLine("Pocetak racunavog poteza: ", igrac.ListaKarata);
            //   debug();
            // Zabrani igraču da baca karte dok je red na računalo
            pictureBox5.Enabled = false;

            Random random = new Random();
            if (karteNaStolu.Count > 0)
            {

                // Pogađanje
                Random randomGuess = new Random();
                int rGuess = random.Next(0, 2);
                if (rGuess == 1)
                {
                    pictureBox1.Show();
                    if (karteNaStolu[karteNaStolu.Count - 1].Boja == pocetnaBoja)
                    {
                        foreach (Karta k in karteNaStolu)
                        {
                            računalo.DodajKartu(k);
                        }
                        int index = random.Next(boje.Count);
                        var randomBoja = boje[index];
                        pocetnaBoja = randomBoja;
                        karteNaStolu.Clear();
                        label10.Text = "Računalo je promašilo da igrač laže";
                    }
                    else
                    {
                        foreach (Karta k in karteNaStolu)
                        {
                            igrac.DodajKartu(k);
                        }
                        pocetnaBoja = "";
                        karteNaStolu.Clear();
                        pictureBox5.Enabled = true;
                        button2.Hide();
                        label10.Text = "Računalo je pogodilo da igrač laže.";
                        updateLabele();
                        return;
                    };
                }
                else
                {
                    label10.Text = "Računalo nije pogađalo.";

                }
            }
            else
            {
                int index = random.Next(boje.Count);
                var randomBoja = boje[index];
                pocetnaBoja = randomBoja;
                updateLabele();
            }
            random = new Random();
            int r = random.Next(0, računalo.ListaKarata.Count);
            karteNaStolu.Add(računalo.ListaKarata[r]);
            label9.Text = "Računalo bacilo  " + računalo.ListaKarata[r].FileName;
            pictureBox1.Image = računalo.ListaKarata[r].Image;

            //uklanju kartu koju je računalo bacilo
            pictureBox1.Hide();
            računalo.BaciKartu(računalo.ListaKarata[r]);

            if (računalo.ListaKarata.Count == 0)
            {
                // povezivanje baze i dodavanje novog pobjednika
                SqlConnection sqlcon = new SqlConnection(@"Data Source=Lubar;Initial Catalog=Lazljivac;Integrated Security=True");
                string query1 = "Insert into [Igra] (ID, Trajanje,Pobjednik) values (1 ," + ticks.ToString() + ", 'Racunalo')";
                SqlDataAdapter sda1 = new SqlDataAdapter(query1, sqlcon);
                DataTable dtbl1 = new DataTable();

                sda1.Fill(dtbl1);
                MessageBox.Show("Igra je gotova! Pobjednik je računalo");

                this.Close();

            }

            // Računalo dobiva novu kartu iz špila
            Random rand = new Random();
            int ran = rand.Next(0, spilKarata.Count);
            if (spilKarata.Count > 0)
            {
                računalo.DodajKartu(spilKarata[ran]);
                spilKarata.RemoveAt(ran);
            }

            if (računalo.ListaKarata.Count == 0)
            {
                zavrsiIgru();
            }

            updateLabele();
            trenutnaKarta = igrac.ListaKarata[0];
            pictureBox1.Image = trenutnaKarta.Image;
            //   System.Diagnostics.Debug.WriteLine("Kraj racunavog poteza: ", igrac.ListaKarata);
            //   debug();
        }



        public void updateLabele()
        {
            label4.Text = "Boja: " + pocetnaBoja;
            label5.Text = "Broj karata: " + igrac.ListaKarata.Count;
            label6.Text = "Broj karata: " + računalo.ListaKarata.Count;
            label7.Text = "Broj karata u spilu: " + spilKarata.Count;
            label8.Text = "Broj karata na stolu: " + karteNaStolu.Count;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_MouseClick(object sender, MouseEventArgs e)
        {
            int indeksTrenutne = igrac.ListaKarata.IndexOf(trenutnaKarta);
            if (indeksTrenutne < igrac.ListaKarata.Count - 1)
            {
                pictureBox5.Image = igrac.ListaKarata[indeksTrenutne + 1].Image;
                trenutnaKarta = igrac.ListaKarata[indeksTrenutne + 1];

            }
            else
            {
                pictureBox5.Image = igrac.ListaKarata[0].Image;
                trenutnaKarta = igrac.ListaKarata[0];
            }
        }

        private void pictureBox6_MouseClick(object sender, MouseEventArgs e)
        {
            int indeksTrenutne = igrac.ListaKarata.IndexOf(trenutnaKarta);
            if (indeksTrenutne > 0)
            {
                pictureBox5.Image = igrac.ListaKarata[indeksTrenutne - 1].Image;
                trenutnaKarta = igrac.ListaKarata[indeksTrenutne - 1];

            }
            else
            {
                pictureBox5.Image = igrac.ListaKarata[igrac.ListaKarata.Count - 1].Image;
                trenutnaKarta = igrac.ListaKarata[igrac.ListaKarata.Count - 1];
            }
        }

        /*    private void debug()
            {
                System.Diagnostics.Debug.WriteLine("Karte na stolu: ");
                foreach (Karta k in karteNaStolu)
                {
                    System.Diagnostics.Debug.WriteLine(k.FileName);
                }

                System.Diagnostics.Debug.WriteLine("Karte igraca: ");
                foreach (Karta k in igrac.ListaKarata)
                {
                    System.Diagnostics.Debug.WriteLine(k.FileName);
                }

                System.Diagnostics.Debug.WriteLine("Karte racunala: ");
                foreach (Karta k in računalo.ListaKarata)
                {
                    System.Diagnostics.Debug.WriteLine(k.FileName);
                }
            }
        }*/

        public void zavrsiIgru()
        {
            string pobjednik = "";
            if (igrac.ListaKarata.Count <= računalo.ListaKarata.Count)
            {
                pobjednik = igrac.Ime;
            }
            else
            {
                pobjednik = računalo.Ime;
            }

            SqlConnection sqlcon = new SqlConnection(@"Data Source=Lubar;Initial Catalog=Lazljivac;Integrated Security=True");

            string query1 = "Insert into [Igra] (ID, Trajanje, Pobjednik) values (1," + ticks.ToString() + ", '" + pobjednik + "')";
            SqlDataAdapter sda1 = new SqlDataAdapter(query1, sqlcon);
            DataTable dtbl1 = new DataTable();

            sda1.Fill(dtbl1);
            MessageBox.Show("Igra je gotova! Pobjednik je " + pobjednik);
            this.Close();
        }
    }
}
