using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ukol10
{
    class Osoba
    {
        protected string jmeno;
        string prijmeni;
        int hmotnost;
        double vyska;

        public Osoba(string jmeno, string prijmeni, int hmotnost, double vyska)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.hmotnost = hmotnost;
            this.vyska = vyska;

        }

        string Jmeno
        {
            get; set;
        }
        string Prijmeni
        {
            get; set;
        }
        int Hmotnost
        {
            get { return hmotnost;  } 
            set
            {
                if(value > 0 && value <= 300)
                {

                }
                else
                {
                    MessageBox.Show("Hmotnot mimo rozsah");
                }
            }
        }
        double Vyska
        {
            get { return vyska; }
            set
            {
                if(value > 100)
                {
                    value = value / 100;
                }
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }

        double BMI()
        {

            return (hmotnost / (vyska * vyska));
        }



    }
}
