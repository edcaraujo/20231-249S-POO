using System.Collections.Generic;
using System;

namespace _3166
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] l = Console.ReadLine().Split();

            int n = int.Parse(l[0]);
            int m = int.Parse(l[1]);
            int p = int.Parse(l[2]);

            List<string> words = new List<string>();

            for (int i = 0; i < n; i++)
            {
                words.Add(Console.ReadLine().ToLower());
            }

            List<string> puzzle = new List<string>();

            for (int i = 0; i < m; i++)
            {
                puzzle.Add(Console.ReadLine().ToLower());
            }

            string nw = "";
            string rw = "";

            for (int i = 0; i < m; i++)
            {
                nw = nw + puzzle[i][i];
                rw = rw + puzzle[m - 1 - i][m - 1 - i];
            }

            List<string> uwords = new List<string>();
            List<string> dwords = new List<string>();

            for (int i = m - 1; i > 0; i--)
            {
                string dnw = "";
                string drw = "";

                string unw = "";
                string urw = "";

                for (int j = 0; j < m - i; j++)
                {
                    dnw = dnw + puzzle[i + j][j];
                    drw = puzzle[i + j][j] + drw;
                    unw = unw + puzzle[j][i + j];
                    urw = puzzle[j][i + j] + urw;
                }

                dwords.Add(dnw);
                dwords.Add(drw);
                uwords.Add(unw);
                uwords.Add(urw);
            }

            List<int> results = new List<int>();

            foreach (string w in words)
            {
                if (nw.Contains(w) || rw.Contains(w))
                {
                    results.Add(1);
                    continue;
                }

                bool exist = false;

                foreach (string uw in uwords)
                {
                    if (uw.Contains(w))
                    {
                        results.Add(2);
                        exist = true;
                        break;
                    }
                }

                if (exist)
                {
                    continue;
                }

                foreach (string dw in dwords)
                {
                    if (dw.Contains(w))
                    {
                        results.Add(3);
                        exist = true;
                        break;
                    }
                }

                if (exist)
                {
                    continue;
                }

                results.Add(4);
            }


            for (int i = 0; i < words.Count; i++)
            {
                if (results[i] == 1)
                {
                    Console.WriteLine($"1 Palavra \"{words[i]}\" na diagonal principal");
                }
                else if (results[i] == 2)
                {
                    Console.WriteLine($"2 Palavra \"{words[i]}\" acima da diagonal principal");
                }
                else if (results[i] == 3)
                {
                    Console.WriteLine($"3 Palavra \"{words[i]}\" abaixo da diagonal principal");
                }
                else
                {
                    Console.WriteLine($"4 Palavra \"{words[i]}\" inexistente");
                }
            }
        }
    }
}