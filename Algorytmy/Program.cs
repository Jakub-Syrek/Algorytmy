using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorytmy
{


    class Program
    {
        static string st = "AABBBCCC";

        static int[] result = new int[st.Length];

        static int[] ReturnAggregated(string _st)
        {
            return null;
        }

        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            Debug.Assert(T >= 1 && T <= 15);

            string s = Console.ReadLine();

            Debug.Assert(s.Length >= 1 && s.Length <= 200_000);

            int Q = int.Parse(Console.ReadLine());

            Debug.Assert(Q >= 1 && Q <= 100_000);

            for (int i = 0; i < Q; i++)
            {
                Solution1(s);
            }

        }

        static void Solution1(string s)
        {
            string[] tab = (Console.ReadLine()).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int[] tabInt = Array.ConvertAll(tab, int.Parse);

            int querryType = tabInt[0];

            int i = tabInt[1];

            StringBuilder sb = new StringBuilder(s);  //!! 

            if (querryType == 2)
            {

                //zamien litere na krzyzyk
                sb[i] = '#';
            }
            else if (querryType == 1)
            {
                //oblicz
                int b = i;
                for (b = 0; b >= 0; b--)
                {
                    if (sb[i] != sb[b]) break;
                }
                b++;

                int e = i;
                for (e = i; e < sb.Length; e++)
                {
                    if (sb[i] != sb[b]) break;
                }
                e--;
                Console.WriteLine(e - b + 1);

            }
            else
            {
                throw new ArgumentException();
            }
            //wczytaj instrukcje
            //wypisz wynik
        }
    }
}
