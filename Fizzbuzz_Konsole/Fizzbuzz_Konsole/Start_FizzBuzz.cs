using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz_Konsole
{
    class Start_FizzBuzz
    {
        public static int[] UG_OG_Eingeben()
        {
            int[] array = new int[] { 0, 0 };
            Console.WriteLine("Untergrenze: ");
            array[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Obergrenze: ");
            array[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------");
            return array;
        }

        public static Dictionary<int, string> Zahlen_auswerten(int untergrenze, int obergrenze)
        {
            var zahlen = new Dictionary<int, string>();
            //var test = UG_OG_Eingeben();

            for (int i = untergrenze; i <= obergrenze; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    zahlen.Add(i, "FizzBuzz");

                }
                else if (i % 3 == 0 && i % 5 != 0)
                {
                    zahlen.Add(i, "Fizz");

                }
                else if (i % 3 != 0 && i % 5 == 0)
                {
                    zahlen.Add(i, "Buzz");

                }
                else
                {
                    zahlen.Add(i, Convert.ToString(i));
                }
            }

            //foreach (KeyValuePair<int, string> item in zahlen)
            //{
            //    Console.WriteLine(item.Value);
            //}

            return zahlen;
        }
        public static Dictionary<int, string> Zahlen_ausgeben()
        {
            var ug_og = UG_OG_Eingeben();
            var zahlen = Zahlen_auswerten(ug_og[0], ug_og[1]);
            foreach (KeyValuePair<int, string> item in zahlen)
            {
                Console.WriteLine(item.Value);
            }
            return zahlen;
        }
    }
}

