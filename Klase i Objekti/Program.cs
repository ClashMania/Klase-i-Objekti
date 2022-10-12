using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klase_i_Objekti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instanciranje objekata
            Osoba osoba = new Osoba();

            osoba.SetIme("Pero");
            osoba.SetPrezime("Perić");
            osoba.SetGodRodjenja(2005);
            osoba.SetVisina(179);
            osoba.SetTezina(89);
            osoba.SetSpol('M');


            // Ispis podataka
            Console.WriteLine("Osoba 1");
            Console.WriteLine("Ime i prezime: " + osoba.GetIme() + " " + osoba.GetPrezime());
            Console.WriteLine("Godina rođenja: " + osoba.GetGodRodjenja());
            Console.WriteLine("Visina i težina: " + osoba.GetVisina() + " i " + osoba.GetTezina());
            Console.WriteLine("Spol: " + osoba.GetSpol());

          

            // Instanciranje objekata 2
            Osoba osoba2 = new Osoba("Ana", "Anić", 2001, 164, 64, 'Ž');
            Console.WriteLine("\r\nOsoba 2");
            Console.WriteLine(osoba2.Ispis());
            

            Console.WriteLine("\r\nOsoba 2 - override");
            Console.WriteLine(osoba2.ToString());





            Console.ReadKey();
        }
  }

    class Osoba
    {
        // Svojstva
        string ime, prezime;
        int godRodjenja, visina, tezina;
        char spol;

        // Metode



        // Set metode
        public void SetIme(string ime)
        {
            this.ime = ime;
        }
        public void SetPrezime(string prezime)
        {
            this.prezime = prezime;
        }
        public void SetGodRodjenja(int godRodjenja)
        {
            this.godRodjenja = godRodjenja;
        }
        public void SetVisina(int visina)
        {
            this.visina = visina;
        }
        public void SetTezina(int tezina)
        {
            this.tezina = tezina;
        }
        public void SetSpol(char spol)
        {
            this.spol = spol;
        }

        // Get metode

        public string GetIme()
        {
            return this.ime;
        }
        public string GetPrezime()
        {
            return this.prezime;
        }
        public int GetGodRodjenja()
        {
            return this.godRodjenja;
        }
        public int GetVisina()
        {
            return this.visina;
        }
        public int GetTezina()
        {
            return this.tezina;
        }
        public char GetSpol()
        {
            return this.spol;
        }

        // Metode za ispis
        public string Ispis()
        {
          
            string ispis = "Ime i prezime: " 
                + this.GetIme() + " " + this.GetPrezime() 
                + "\r\nGodina rođenja: " + this.GetGodRodjenja() 
                + "\r\nVisina i težina: " + this.GetVisina() 
                + " i " + this.GetTezina() 
                + "\r\nSpol: " + this.GetSpol();
           
            
            return ispis;
        }

        public override string ToString()
        {
            string ispis = "Ime i prezime: "
                + this.GetIme() + " " + this.GetPrezime()
                + "\r\nGodina rođenja: " + this.GetGodRodjenja()
                + "\r\nVisina i težina: " + this.GetVisina()
                + " i " + this.GetTezina()
                + "\r\nSpol: " + this.GetSpol();

            return ispis;
        }

        // Konstruktori

        public Osoba()
            {
                
            }

        public Osoba(string ime, string prezime, int godRodjenja, int visina, int tezina, char spol)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.godRodjenja = godRodjenja;
            this.visina = visina;
            this.tezina = tezina;
            this.spol = spol;
        }

        public Osoba(string ime, string prezime)
        {
            this.ime = ime;
            this.prezime = prezime;
        }
    }

}
