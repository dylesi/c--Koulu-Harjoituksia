using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Muuttujat ja tulostaminen
            //1.Aseta muuttujaan tekstu. Tulosta kyseinen muuttuja.

            Console.WriteLine("Tehtävä 1.");
            string muuttuja = "teksti";
            Console.WriteLine(muuttuja);
            Console.WriteLine("--------------");

            //2.Aseta kahteen eri muutujaan haluamasi kokonaisluvut.Tulosta niiden summa.

            Console.WriteLine("Tehtävä 2.");
            int numero1 = 2;
            int numero2 = 4;
            Console.WriteLine(numero1 + numero2);
            Console.WriteLine("--------------");

            //3.Aseta kolmelle muutujalle haluamasi lukuarvot. Tulosta niiden keskiarvo.
            //Keskiarvo = lukujen summa jaetuna lukujen määrällä.
            //Esimerkiksi: 1,2,6: Keskiarvo 3.

            Console.WriteLine("Tehtävä 3.");
            int numero3 = 2;
            int numero4 = 5;
            int numero5 = 6;
            Console.WriteLine((numero3 + numero4 + numero5) / 3);
            Console.WriteLine("--------------");

            //4.Aseta muutujalle kokonaisluku arvo.Tulosta se. Aseta samalle muutujalle toinen arvo.Tulosta se

            Console.WriteLine("Tehtävä 4.");
            int numero6 = 3;
            Console.WriteLine(numero6);
            numero6 = 4;
            Console.WriteLine(numero6);
            Console.WriteLine("--------------");


            //Muuttujan arvon muutaminen
            //1.Aseta kahdelle kokonaislukumuutujalle haluamasi arvot. Tulosta molemmat. Kasvat ensimmäistä
            //toisen arvolla. Tulosta kasvatettu muutuja.

            Console.WriteLine("Tehtävä 2.1");
            int numero7 = 5;
            int numero8 = 6;
            Console.WriteLine(numero7);
            Console.WriteLine(numero8);
            numero7 += numero8;
            Console.WriteLine(numero7);
            Console.WriteLine("--------------");

            //2.Aseta kokonaislukumuutujalle haluamasi arvo ja tulosta se. Siten muuta arvo niin, etä se muutuu
            //kaksinkertaiseksi.

            Console.WriteLine("Tehtävät 2.2");
            int numero9 = 3;
            Console.WriteLine(numero9);
            numero9 = numero9 * 2;
            Console.WriteLine(numero9);
            Console.WriteLine("--------------");

            //3.Aseta kahdelle desimaalilukumuutujalle haluamasi arvot. Tulosta molemmat. Muuta ensimmäistä
            //lukua niin, kerrot sen toisella luvulla.Tulosta se.

            Console.WriteLine("Tehtävä 2.3");
            float numero10 = 1.5f;
            float numero11 = 1.6f;
            Console.WriteLine(numero10);
            Console.WriteLine(numero11);
            numero10 = numero10 * numero11;
            Console.WriteLine(numero10);
            Console.WriteLine("--------------");

            //4.Aseta kahdelle kokonaislukumuutujalle haluamasi arvot. Kasvata molempia muutujia niiden
            //summalla.

            Console.WriteLine("Tehtävä 2.4");
            int numero12 = 5;
            int numero13 = 6;
            numero12 = numero12 + (numero12 + numero13);
            numero13 = numero13 + (numero12 + numero13);
            Console.WriteLine(numero12);
            Console.WriteLine(numero13);
            Console.WriteLine("--------------");

            //Input
            //1.Ohjelma kysyy käytäjän nimeä ja terveh�i takaisin muodossa:
            // ”Terve Aarni!” (huomaa huutomerkki lopussa)
            //2.Ohjelma kysyy käytäjän etunimen.Siten sukunimen. Ohjelma tulostaa Bondin kuuluisan lauseen:
            //”Nimeni on Junkkala.Aarni Junkkala.”
            //3.Käytäjä syötää luvun. Ohjelma tulostaa siitä yhden suuremman luvun.
            //4.Käytäjä syötää luvun. Siten käytäjä syötää toisen luvun.Ohjelma laskee näiden lukujen tulon ja
            //tulostaa sen.

            Console.WriteLine("Input Tehtävä");
            Console.WriteLine("Syötä Etunimi: ");
            string etunimi = Console.ReadLine();

            Console.WriteLine("Syötä Sukunimi: ");
            string sukunimi = Console.ReadLine();

            Console.WriteLine("Anna luku:");
            string number1 = Console.ReadLine();
            int number_1 = int.Parse(number1);

            Console.WriteLine("Anna toinen luku:");
            string number2 = Console.ReadLine();
            int number_2 = int.Parse(number2);

            Console.WriteLine("Hei " + etunimi + "!");
            Console.WriteLine("Nimesi on " + etunimi + ". " + etunimi + " " + sukunimi + ".");
            Console.WriteLine("Ensimmäinen luku jonka syötit on " + number_1 + " ja se yksi suurempana on " + (number_1 + 1) + ".");
            Console.WriteLine("Syöttämäsi numeroiden " + number_1 + " ja " + number_2 + " summa on: " + (number_1 + number_2) + ".");
            Console.WriteLine("--------------");

            Console.ReadLine(); 
        }
    }
}
