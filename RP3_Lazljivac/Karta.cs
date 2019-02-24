using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace RP3_Lazljivac
{
    public class Karta
    {
        private string _boja;
        private string _fileName;
        private Image _image;
        

        public string Boja
        {
            get { return _boja; }
            set { _boja = value; }
        }
        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }
        public Image Image
        {
            get { return _image; }
            set { _image = value; }
        }


        public Karta()
        { }

        public Karta(string b, string fn)
        {
            this.Boja = b;
            this.FileName = fn;
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string file = string.Format("{0}Resources\\karte\\" + fn, Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            this.Image = Image.FromFile(file);
        }
    }
}
