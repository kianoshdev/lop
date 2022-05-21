using System;

namespace lop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static string re(string input)
            {
                string rev = "";

                char[] chr = input.ToCharArray();

                int m = chr.Length - 1;

                for (int i = 0; i <= input.Length - 1; i++)
                {
                    rev += chr[m];
                    m--;
                }
                return rev;
            }

            int c = 5;

            for (int i = 1; i <= 5; i++)
            {
                int u = 1;
                string p = "";
                string spac = @"";

                while (u < i)
                {
                    p += u.ToString();
                    u++;

                }
                for (int z = 1; z <= c; z++)
                {
                    spac += " ";
                }

                c--;

                Console.WriteLine($"{spac}{p}{i}{re(p)}");
            }
        }
    }
}
