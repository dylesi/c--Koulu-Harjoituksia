using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tehtäväpaketti4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            kaksilistaa();
            Console.ReadLine(); 
        }
        // -----------------------------------------------------
        //Satunnaisluku (desimaali)
        // -----------------------------------------------------

        //kirjoita ohjelma, joka tulostaa satunnaisluvun väliltä 0.0 ja 10.0.
        static void satunnais0_10()
        {
            Random rand = new Random();
            double satunnainendouble = rand.NextDouble() * 10;
            Console.WriteLine(satunnainendouble);
        }


        //Kirjoita ohjelma, joka tulostaa satunnaisluvun väliltä -1.0 ja 1.0
        static void satunnaismin1_1()
        {
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                double satunnainen = rand.NextDouble() * 2 - 1.0;
                Console.WriteLine(satunnainen);
            }
        }

        //3 Kirjoita ohjelma, joka tulostaa koodaus taitosi prosenttina. Luo prosentin arvo satunnaisluvulla väliltä  0.0 ja 100.0
        static void koodausprosentti()
        {
            Random random = new Random();
            double satunnainen = random.NextDouble() * 100;
            Console.WriteLine("Taitosi on " + satunnainen + "%");
        }

        //Kirjoita ohjelma, jossa käyttäjä arvaa joko nolla tai yksi. Luo oikea vastaus satunnaisluvulla väliltä 0.0 ja 
        //1.0, ja tulosta ”voitit”, jos satunnaisluku on lähempänä arvattua kuin toista vaihto ehtoa.Muulloin tulosta 
        //”Hävisit!”. (0.5 pyöristetään ylöspäin)
        static void nollavaiyksi()
        {
            Console.WriteLine("Arvaa 0 tai 1: ");

            string arvaus = Console.ReadLine();
            int arvausnum = int.Parse(arvaus);

            Random random = new Random();
            double satunnainen = random.NextDouble();
            double rounded = Math.Round(satunnainen);
            if (arvausnum == 1 && rounded == 1)
            {
                Console.WriteLine("Voitit!");
            }
            else
            {
                Console.WriteLine("Hävisit!");
            }
            Console.ReadLine();
        }
        // -----------------------------------------------------
        //Satunnaiset kokonaisluvut
        // -----------------------------------------------------

        //Kirjoita ohjelma, tulostaa satunnaisluvut väliltä 12-22.
        static void kaksitoista_kakskaks()
        {
            Random random = new Random();
            int satunnainen = random.Next(12, 22);
            Console.WriteLine(satunnainen);
        }

        //irjoita ohjelma, joka simuloi noppaa. Jos ohjelma saa silmäluvun kuusi, niin ohjelma tulostaa ”Voitit”, 
        //muulloin ”Hävisit”

        static void noppa()
        {
            Console.WriteLine("Jos saat luvun 6, voitat. Kuinka monta kertaa heität noppaa? syötä luku: ");
            string heitto = Console.ReadLine();
            int heittomäärä = int.Parse(heitto);


            Random random = new Random();
            for (int i = 0; i < heittomäärä; i++)
            {
                int noppa = random.Next(7);
                if (noppa == 6)
                {
                    Console.WriteLine("Heitit: "+ noppa + "! " +  "Voitit!");
                }
                else
                {
                    Console.WriteLine("Heitit: " + noppa + "! " + "Hävisit!");
                }
            }
        }

        // Kirjoita ohjelma, joka aloittaa laskemisen numerosta yksi. Ohjelma kasvattaa numero satunnaisluvulla 
        // väliltä 1-6. Lopuksi ohjelma tulostaa, että kuinka monta kertaa lukua kasvatettiin, ennen kuin se saavutti
        // arvon 100.
        static void yhdesta_sataan()
        {
            Random rand = new Random();
            int laskin = 0;
            int numero = 0;
            bool totuus = true;
            while (totuus == true)
            {
                laskin++;
                if (numero > 100 || numero == 100)
                {
                    Console.WriteLine("Luku on nyt: "+ numero + " ja sitä kasvatettiin "+ laskin + " kertaa.");
                    totuus = false;
                }

                else if (numero < 100)
                {
                    int satunnainen = rand.Next(7);
                    numero += satunnainen;
                    Console.WriteLine("Luku on nyt: " + numero);
                }
            }
        }
        //Kirjoita ohjelma, jossa luku on nolla. Lukua kasvatetaan ja vähennetään vuorotellen satunnaisluvulla 
        //väliltä 1-6. Jos luku on -10 tai vähemmän, tulosta ”Pelaaja 1 voitti”, jos luku on 10 tai enemmän, tulosta 
        //”Pelaaja 2 voitti”
        static void miinuskymppipeli()
        {
            int numero = 0;
            bool totuus = true;
            Random random = new Random();

            while (totuus == true)
            {
                if (numero < -10)
                {
                    Console.WriteLine("Pelaaja 1 voitti!");
                    totuus = false;
                }
                else if (numero > 10)
                {
                    Console.WriteLine("Pelaaja 2 voitti!");
                    totuus = false;
                }

                else
                {
                    int satunnainen = random.Next(7);
                    int toinensatunnainen = random.Next(7);
                    numero += satunnainen;
                    numero -= toinensatunnainen;
                    Console.WriteLine(numero);
                }
            }

        }
        // -----------------------------------------------------
        //listat
        // -----------------------------------------------------

        // Kirjoita ohjelma, jossa tulostetaan sattumanvaraisesti listasta valittu alkio (objekti, elementti).
        static void randomlistasta()
        {
            List<string> lista = new List<string>
            {
                "testi",
                "siika",
                "morjenst",
                "pododwoako",
                "lorem",
                "ipsum",
                "dolor",
                "sit",
                "amet"
            };
            Random random = new Random();
            int satunnainen = random.Next(0, lista.Count);
            Console.WriteLine("Listasta satunnainen alkio: "+ lista[satunnainen]);
        }


        //Kirjoita ohjelma, jossa listasta poistetaan sattumanvaraisesti valittuja alkioita, kunnes jäljellä on vain 
        //yksi alkio.Tulosta jäljelle jäänyt alkio.
        static void poistalistasta()
        {
            List<string> lista = new List<string>
            {
                "testi",
                "siika",
                "morjenst",
                "pododwoako",
                "lorem",
                "ipsum",
                "dolor",
                "sit",
                "amet"
            };

            Random rand = new Random();

            while (lista.Count > 1)
            {
                int satunnainen = rand.Next(0, lista.Count);
                lista.RemoveAt(satunnainen);
                if (lista.Count == 1)
                {
                    Console.WriteLine(lista[0]);
                }
            }
        }


        //Kirjoita ohjelma, jossa on kaksi listaa. Ensimmäisessä listassa on numerot ykkösestä sataan. 
        //([1, 2, 3, 4…99, 100). Toinen lista on tyhjä.Lisää toiseen listaan satunnaisia alkioita ensimmäisestä listasta,
        //kunnes olet lisännyt numeron 7.Sen jälkeen tulosta siirtojen määrä.Aina kun siirrät numeron, poista se
        //ensimmäisestä listasta
        static void kaksilistaa()
        {

            List<int> listasata = new List<int> { };
            List<int> listatyhjä = new List<int> { };

            Random rand = new Random();
            Boolean totuus = true;
            int laskuri = 0;

            for (int i = 1; i < 101; i++)
            {
                listasata.Add(i);
            }
           
            while (totuus == true)
            {
                int satunnainen = rand.Next(0, listasata.Count);
                laskuri++;

                int poistettu = listasata[satunnainen];
                listasata.RemoveAt(satunnainen);
                listatyhjä.Add(poistettu);
                
                if (poistettu == 7)
                {
                    listatyhjä.Sort();
                    Console.WriteLine(String.Join(", ", listasata));
                    Console.WriteLine("-------------------");
                    Console.WriteLine(String.Join(", ", listatyhjä));

                    Console.WriteLine("Numero seitsemän on lisätty ja siihen meni " + laskuri + " siirtoa");
                    totuus = false;
                }
            }
        }
    }
}
