using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP3_Lazljivac
{
    class Igrac
    {
        private string _ime;
        private List<Karta> _listaKarata;

        public string Ime {
            get { return _ime; }
            set { _ime = value; }
        }

        public List<Karta> ListaKarata
        {
            get { return _listaKarata; }
            set { _listaKarata = value; }
        }

        public Igrac()
        { }
        public Igrac(string i)
        {
            this.Ime = i;
            this.ListaKarata = new List<Karta>();
        }
         
        public void DodajKartu(Karta karta)
        {
            ListaKarata.Add(karta);
        }

        public void BaciKartu(Karta karta)
        {
            ListaKarata.Remove(karta);
        }

        public int BrojKarata()
        {
            return ListaKarata.Count;
        }
    }
}
