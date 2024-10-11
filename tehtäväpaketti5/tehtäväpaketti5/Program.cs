using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static tehtäväpaketti5.Program;

namespace tehtäväpaketti5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kissa Testi = new Kissa("Testi", 12, "vihreä");
            Kissa Pertti = new Kissa("Pertti", 24, "ruskea");
            Kissa Poro = new Kissa("Poro", 4, "keltainen");

            Testi.lisääListaan(Testi);
            Pertti.lisääListaan(Pertti);
            Poro.lisääListaan(Poro);
            Poro.TulostaLista();

            Ajokortti Matti = new Ajokortti("Matti", 52, 12, 0);
            Ajokortti Saara = new Ajokortti("Saara", 30, 18, 12);
            Ajokortti Janne = new Ajokortti("Janne", 23, 29, 18);

            Matti.Korttiluokka(Matti);
            Matti.Korttiluokka(Saara);
            Matti.Korttiluokka(Janne);

            Oppilas Veeti = new Oppilas("Veeti", new List<Suoritus>() {
            new Suoritus("Matematiikka", 10),
            new Suoritus("Äidinkieli", 7),
            new Suoritus("Englanti", 8),
            new Suoritus("Ruotsi", 6) });

            Oppilas Aarni = new Oppilas("Aarni", new List<Suoritus> () {
            new Suoritus("Matematiikka", 9),
            new Suoritus ("Äidinkieli", 8),
            new Suoritus ("Englanti", 8),
            new Suoritus ("Ruotsi", 5) });

            Oppilas Heikki = new Oppilas("Heikki", new List<Suoritus>()
            {
            new Suoritus("Matematiikka", 9),
            new Suoritus("dkwoa", 10),
            new Suoritus("kdowako", 50),
            });

            Veeti.LaskeKeskiArvo(Veeti);
            Aarni.LaskeKeskiArvo(Aarni);
            Heikki.LaskeKeskiArvo(Heikki);


            Console.ReadLine();
        }

        //-----------------------------------------------------------------------------------------------

        // Kirjoita luokka Kissa, jossa kissalla on seuraavat datat: Nimi, Ikä, Väri.
        // Kissa luokalla tulee olla funktio, joka tulostaa kyseiset datat.
        // Luo listaan ainakin kolme kissaa. Aseta jokaiselle uniikit datat.
        // Tulosta kyseiset data käytäen funktiota.

        internal class Kissa
        {
            public string nimi = "";
            public int ikä = 0;
            public string väri = "";
            public List<Kissa> Kissalista = new List<Kissa>();

            public Kissa(string uusiNimi, int uusiIkä, string uusiVäri)
            {
                ikä = uusiIkä;
                nimi = uusiNimi;
                väri = uusiVäri;
            }

            public void lisääListaan(Kissa kiisu)
            {
                Kissalista.Add(kiisu);
                Console.WriteLine("Listan pituus on nyt: " + Kissalista.Count);
            }
            public void TulostaKissa()
            {
                Console.WriteLine("Kissan nimi on: " + nimi + ". Se on " + ikä + " vuotta vanha ja väriltään " + väri);
            }

            public void TulostaLista()
            {
                foreach (var Kissa in Kissalista)
                {
                    Console.WriteLine(Kissa.nimi + ", " + Kissa.ikä + ", " + Kissa.väri);
                }
            }
        }

        //-----------------------------------------------------------------------------------------------
        //Kirjoita luokka Ajokortti, jossa on seuraavat datat: Nimi, Ikä, A-kokeen tulos ja B-kokeen tulos ja 
        //korttiluokka(string).
        //Luokalla tulee olla funktio, joka laskee ajo-oikeuden seuraavalla tavalla:
        //Korttiluokka on tyhjä (””), jos henkilö on alaikäinen, tai A-kokeen tulos on alle 15 pistetä
        //Korttiluokka on A, jos henkilö on saanut A kokeesta yli 15 pistetä.
        //Korttiluokka on B, jos henkilö on saanut A kokeesta yli 20 pistetä ja B kokeesta yli 15 pistetä.
        //Testaa seuraavat henkilöt:
        //1. Matti 52, 12, 0 -> ””
        //2. Saara 30, 18,12 -> ”A”
        //3. Janne 23, 29, 18 -> ”B

        internal class Ajokortti
        {
            public string nimi = "";
            public int ikä = 0;
            public int a_Koe = 0;
            public int b_Koe = 0;
            public string korttiluokka = "";

            public Ajokortti(string uusinimi, int uusiIkä, int uusi_a_Koe, int uusi_b_Koe)
            {
                nimi = uusinimi;
                ikä = uusiIkä;
                a_Koe = uusi_a_Koe;
                b_Koe = uusi_b_Koe;
            }

            public void Korttiluokka(Ajokortti tiedot)
            {

                //Ajokortti Janne = new Ajokortti("Janne", 23, 29, 18);
                if (tiedot.ikä < 18 || tiedot.a_Koe < 15)
                {
                    korttiluokka = "Henkilöllä " + tiedot.nimi + " ei ole ajokorttia: \"\"";
                    Console.WriteLine(korttiluokka);
                }
                else if (tiedot.a_Koe > 15 && tiedot.b_Koe > 15)
                {
                    korttiluokka = "Henkilön: " + tiedot.nimi + " ajokorttiluokka on \"B\"";
                    Console.WriteLine(korttiluokka);
                }
                else if (tiedot.a_Koe > 15)
                {
                    korttiluokka = "Henkilön: " + tiedot.nimi + " ajokorttiluokka on \"A\"";
                    Console.WriteLine(korttiluokka);
                }


            }

        }

        //-----------------------------------------------------------------------------------------------
        //Kirjoita luokka Oppilas ja luokka Suoritus. Suoritus-luokassa tulee olla muutujat oppiaine ja 
        //arvosana.Oppilas-luokassa tulee olla muutujat nimi ja lista suorituksista.    Oppilas-luokassa tulee
        //olla funktio LaskeKeskiarvo(), joka laskee oppilaan arvosanojen keskiarvon ja tulostaa sen.


        public class Oppilas
        {
            public string nimi = "";
            public List<Suoritus> suorituslista = new List<Suoritus> { };

            public Oppilas(string uusiNimi, List<Suoritus> uusiLista)
            {
                nimi = uusiNimi;
                suorituslista = uusiLista;

            }

            public void LaskeKeskiArvo(Oppilas oppilas)
            {
                double numero = 0;

                for (int i = 0; i < oppilas.suorituslista.Count; i++)
                {
                    numero += oppilas.suorituslista[i].arvosana;
                  
                }

                double lopullinen_arvosana = numero / oppilas.suorituslista.Count;

                Console.WriteLine("Oppilaan " + oppilas.nimi + " keskiarvo on: " + (lopullinen_arvosana));
            }
        }

        public class Suoritus
        {
            public string oppiaine = "";
            public int arvosana = 0;
            public Suoritus(string uusiOppiaine, int uusiArvosana)
            {
                oppiaine = uusiOppiaine;
                arvosana = uusiArvosana;
            }
        }
    }
}
