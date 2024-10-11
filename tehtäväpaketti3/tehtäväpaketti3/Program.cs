using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace tehtäväpaketti3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            tervemaailma();
            tervetervemaailma();
            autskymmenen();
            kaksinkertainen(10);
            yksi_isompi(5);
            tervehdys("Matti");
            helloworld(5);
            yhteenlasku(1, 2);
            positiiviseksi(-5);
            viimeinenkirjain("Daniel");

            Console.ReadLine();

        }


        // Kirjoita funktio, jota kutsuessa ohjelma tulostaa ”Terve maailma!”. Kutsu funktio
        static void tervemaailma()
        {
            Console.WriteLine("Terve maailma!");
        }

        // Kirjoita funktio, joka kutsuu edellisessä tehtävässä tehtyä funktiota. Kutsu funktio.
        static void tervetervemaailma()
        {
            tervemaailma();
        }

        //Kirjoita funktio, joka tulostaa 10 kertaa ”AUTS!”. Kutsu funktio.
        static void autskymmenen()
        {
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("AUTS!");
            }
        }

        //Kirjoita funktio, jonka parametrinä syötetä arvo tulostetaan kaksinkertaisena.
        static void kaksinkertainen(int luku1)
        {
            Console.WriteLine(luku1 * 2);
        }

        //Kirjoita ohjelma, joka tulostaa parametrinä syötetystä arvosta yhden suuremman
        static void yksi_isompi(int luku1)
        {
            Console.WriteLine(luku1 + 1);
        }

        //Kirjoita funktio, joka tervehtii sitä henkilöä, kenen nimi on parametrinä
        static void tervehdys(string nimi)
        {
            Console.WriteLine("Terve " + nimi + "!");
        }


        //Kirjoita funktio, joka tulostaa ”Hello World!”, niin monta kertaa kuin on argumentin arvo.
        static void helloworld(int luku1)
        {
            for(int i = 0; i < luku1; i++)
            {
                Console.WriteLine("Hello World!");
            }
        }

        //Kirjoita funktio, joka palautaa kahden parametrin summan.
        static int yhteenlasku(int luku1, int luku2)
        {
            return luku1 + luku2;
        }


        //Kirjoita funktio, joka palauttaa argumentin positiivisena.
        static void positiiviseksi(int luku1)
        {
            if (luku1 < 0)
            {
                Console.WriteLine(luku1 - (luku1 + luku1));
            }
            else
            {
                Console.WriteLine(luku1);
            }
        }

        //Kirjoita funktio, joka palautaa argumenttina syötetyn nimen viimeisen kirjaimen
        static void viimeinenkirjain(string nimi)
        {
            int nimenpituus = nimi.Length;
            Console.WriteLine(nimi[nimenpituus - 1]);
        }
    }
}
