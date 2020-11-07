using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS322_DZ05_BojanPetrovic2745
{
    class Posetioc
    {
        private string ime;
        private string prezime;
        private int brojUlaznice;

        public string Ime
        {
            get {return ime;} 
            private set { ime = value; }
        }

        

        public Posetioc(string ime, string prezime, int brojUlaznice)
        {
            Ime = ime;
            Prezime = prezime;
            BrojUlaznice = brojUlaznice;
        }

        public string Prezime
        {
            get { return prezime; }
            private set { prezime = value; }
        }

        public int BrojUlaznice
        {
            get { return brojUlaznice; }
            private set { brojUlaznice = value; }
        }

        public void PrintPosetioc()
        {
            Console.WriteLine("Ime: " + Ime + " Prezime: " + Prezime + " Broj ulaznice: " + BrojUlaznice);
        }

    }
}
