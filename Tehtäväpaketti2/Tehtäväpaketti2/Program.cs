using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Tehtäväpaketti2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PIN - koodi.Ohjelma kysyy käytäjältä PIN - koodia.Oikea koodi on 1234.Käytäjälle tulostetaan, etä
            //oliko vastaus oikein.

            //2.Portsari.Ohjelma kysyy käytäjän iän.Jos käytäjä on alaikäinen, niin ohjelma pyytää häntä
            //poistumaan, muulloin ohjelma toivotaa hänet tervetulleeksi.

            //3.Arvosanat.Ohjelma kysyy käytäjältä arvosanaa.Ohjelma tulostaa arvosanan nimellisen muodon:
            //0 Hyläty
            //1 tai 2 Tyydytävä
            //3 tai 4 Hyvä
            //5 Erinomainen

            //4.Huvipuistolaite.Jota pääset huvipuistolaiteeseen, tulee sinun olla ainakin 15 vuota vanha ja
            //vähintään 160 cm pitkä. Ohjelma kysyy molempia �etoja ja kertoo, etä saako käytäjä mennä
            //huvipuistolaiteeseen.

            Console.WriteLine("Tehtävä: Ehtolauseet");
            Console.WriteLine("Anna PIN-koodi: ");
            string koodi = Console.ReadLine();
            int koodinumero = int.Parse(koodi);
            if (koodinumero == 1234)
            {
                Console.WriteLine("Koodi on oikein!");
            }
            else
            {
                Console.WriteLine("Koodi väärin!");
            }

            Console.WriteLine("Anna ikäsi: ");
            string ikä1 = Console.ReadLine();
            int ikä = int.Parse(ikä1);

            if (ikä > 18 || ikä == 18)
            {
                Console.WriteLine("Olet täysi-ikäinen, tervetuloa!");
            }
            else
            {
                Console.WriteLine("Olet ala-ikäinen, ota tikkari!");
            }

            Console.WriteLine("Anna arvosanasi: ");
            string arvosana1 = Console.ReadLine();
            int arvosana = int.Parse(arvosana1);

            if (arvosana < 0 || arvosana == 0)
            {
                Console.WriteLine("Hylätty!");
            }
            else if (arvosana == 1 || arvosana == 2) 
            {
                Console.WriteLine("Tyydyttävä");
            }
            else if(arvosana == 3 || arvosana == 4)
            {
                Console.WriteLine("Hyvä");
            }
            else if (arvosana > 5)
            {
                Console.WriteLine("Kiitettävä");
            }

            Console.WriteLine("Anna pituutesi: ");
            string pituus1 = Console.ReadLine();
            int pituus = int.Parse(pituus1);

            if (ikä > 15 || ikä == 15 && pituus > 160 || pituus == 160)
            {
                Console.WriteLine("Olet " + ikä + " vuotta vanha ja pituutesi on " + pituus + " cm. Tervetuloa!");
            }
            else if (ikä < 15)
            {
                Console.WriteLine("Olet " + ikä + " vuotta vanha. Ikäraja on 15 vuotta");
            }
            else if(pituus < 160)
            {
                Console.WriteLine("Olet " + pituus + " cm pitkä. Pituusraja on 160cm.");
            }

            Console.WriteLine("Toistolause:");
            //For - toistolause
            //1.Kirjoita for-toistolause, joka tulostaa luvut nollasta viiteen.
            Console.WriteLine("nollasta viiteen");
            for (int i = 0; i < 5 + 1; i++)
            {
                Console.WriteLine(i);
            }

            //2.Kirjoita for-toistolause, joka tulostaa luvut käytäjän syötämään lukuun as�.
            //Käytäjä syötää luvun 5, ohjelma tulostaa 0, 1, 2, 3, 4, 5

            Console.WriteLine("Syötä luku mihin asti toistetaan");
            string mihinasti = Console.ReadLine();
            int numeromihinasti = int.Parse(mihinasti);

            for (int i = 0; i < numeromihinasti; i++)
            {
                Console.WriteLine(i);
            }

            //3.Kirjoita for-toistolause, joka tulostaa luvut kymmenestä viiteentoistaan.

            Console.WriteLine("kymmenestä viitentoista.");

            for (int i = 10; i < 15 + 1; i++)
            {
                Console.WriteLine(i);
            }

            //4.Kirjoita for-toistolause, joka tulostaa luvut kymmenestä nollaan. (10, 9, 8, jne.).

            Console.WriteLine("kymmenestä nollaan");
            for (int i = 10; i > -1; i--)
            {
                Console.WriteLine(i);   
            }

            //5.Kirjoita for-toistolause, joka tulostaa viiden kertotaulun kymmenenteen toistoon as� 
            //(5, 10, 15…40, 45, 50).

            Console.WriteLine("viiden kertotaulu");
            for (int i = 5; i < 51; i = i + 5)
            {
                Console.WriteLine(i);
            }

            //6.Kirjoita for-toistolause, joka kirjoitaa joka toisen luvun yhdestä yhdeksään(1, 3, 5, 7, 9)

            Console.WriteLine("Joka toinen luku yhdestä yhdeksään");
            for (int i = 0; i < 11; i++)
            {
                if (i % 2 != 0) 
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
