using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Decizie();
        }

        public static void Decizie()
        {
            Console.WriteLine("Vreti sa calculati greutatea si dimensiune sau doar dimensiunea?");
            Console.Write("1 Doar dimensiunile, 2 Ambele ");
            var input = Console.ReadLine();

            if (input == "1")
            {
                C1();
            }
            else if (input == "2")
            {
                C2();
            }
            else if (input == "8312")
            {
                Console.WriteLine("DANGER IS THE BEST!!!");
                Decizie();
            }
            else
            {
                Console.WriteLine("INTRODUCETI 1 SAU 2");
                Decizie();
            }
        }

        public static void CalculeazaGreutate()
        {
            Console.Write("Introdu grame ");
            var grame = Console.ReadLine();

            float Num;
            bool isNum = float.TryParse(grame.ToString(), out Num);
            if (isNum)
            {
                var kg = Convert.ToDouble(grame) / 1000;
                decimal result;
                Decimal.TryParse(Convert.ToString(kg), System.Globalization.NumberStyles.Float, null, out result);
                Console.WriteLine("Greutate " + result);
            }
            else
            {
                Console.WriteLine("VALOARE INCORECTA. Restart");
                Decizie();
            }
        }
        public static void CalculeazaDimensiuni()
        {
            Console.Write("Introdu inaltime ");
            var inaltime = Console.ReadLine();
            float Num1;
            bool isNum1 = float.TryParse(inaltime.ToString(), out Num1);
            if (isNum1)
            {

            }
            else
            {
                Console.WriteLine("VALOARE INCORECTA. Restart");
                Decizie();
            }

            Console.Write("Introdu lungime ");
            var lungime = Console.ReadLine();
            float Num2;
            bool isNum2 = float.TryParse(lungime.ToString(), out Num2);
            if (isNum2)
            {

            }
            else
            {
                Console.WriteLine("VALOARE INCORECTA. Restart");
                Decizie();
            }

            Console.Write("Introdu latime ");
            var latime = Console.ReadLine();
            float Num3;
            bool isNum3 = float.TryParse(latime.ToString(), out Num3);
            if (isNum3)
            {

            }
            else
            {
                Console.WriteLine("VALOARE INCORECTA. Restart");
                Decizie();
            }

            var M3 = (Convert.ToDouble(inaltime) / 100) * (Convert.ToDouble(lungime) / 100) * (Convert.ToDouble(latime) / 100);

            decimal result2;
            Decimal.TryParse(Convert.ToString(M3), System.Globalization.NumberStyles.Float, null, out result2);
            Console.WriteLine("Dimensiune " + result2);
            Console.WriteLine("");
        }

        public static void C1()
        {
            while (true)
            {
                CalculeazaDimensiuni();
            }
        }
        public static void C2()
        {
            while (true)
            {
                CalculeazaGreutate();
                CalculeazaDimensiuni();
            }
        }
    }
}