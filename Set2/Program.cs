using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Set2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul problemei: ");
            switch (Console.ReadLine())
            {
                case "1":
                    {
                        P1();
                        break;
                    }
                case "2":
                    {
                        P2();
                        break;
                    }
                case "3":
                    {
                        P3();
                        break;
                    }
                case "4":
                    {
                        P4();
                        break;
                    }
                case "5":
                    {
                        P5();
                        break;
                    }
                case "6":
                    {
                        P6();
                        break;
                    }
                case "7":
                    {
                        P7();
                        break;
                    }
                case "8":
                    {
                        P8();
                        break;
                    }
                case "9":
                    {
                        P9();
                        break;
                    }
                case "10":
                    {
                        P10();
                        break;
                    }
                case "11":
                    {
                        P11();
                        break;
                    }
                case "12":
                    {
                        P12();
                        break;
                    }
                case "13":
                    {
                        P13();
                        break;
                    }
                case "14":
                    {
                        P14();
                        break;
                    }
                case "15":
                    {
                        P15();
                        break;
                    }
                case "16":
                    {
                        P16();
                        break;
                    }
                case "17":
                    {
                        P17();
                        break;
                    }
            }
        }

        private static void P1()
        {
            Console.WriteLine("\nProblema 1");
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine()), k = 0;
            Console.WriteLine("Introduceti numerele din secventa:\n(dupa fiecare numar apasati tasta Enter)");
            for (int i = 0; i < n; i++)
            {
                int j = int.Parse(Console.ReadLine());
                if (j % 2 == 0)
                {
                    k++;
                }
            }
            Console.WriteLine($"{k} numere sunt pare");
            Console.ReadKey();
        }

        private static void P2()
        {
            Console.WriteLine("\nProblema 2");
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine()), m = 0, z = 0, p = 0;
            Console.WriteLine("Introduceti numerele din secventa:\n(dupa fiecare numar apasati tasta Enter)");
            for (int i = 0; i < n; i++)
            {
                int k = int.Parse(Console.ReadLine());
                if (k < 0)
                {
                    m++;
                }
                else if (k == 0)
                {
                    z++;
                }
                else if (k > 0)
                {
                    p++;
                }
            }
            Console.WriteLine($"{m} numere sunt negative, {z} numere sunt egale cu zero, {p} numere sunt pozitive");
            Console.ReadKey();
        }

        private static void P3()
        {
            Console.WriteLine("\nProblema 3");
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine()), s = 0, p = 1;
            Console.WriteLine("Introduceti numerele din secventa:\n(dupa fiecare numar apasati tasta Enter)");
            for (int i = 1; i <= n; i++)
            {
                s = s + i;
                p = p * i;
            }
            Console.WriteLine($"Suma: {s} Produsul: {p}");
            Console.ReadKey();
        }

        private static void P4()
        {
            Console.WriteLine("\nProblema 4");
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti numarul a: ");
            int a = int.Parse(Console.ReadLine());
            bool ok = false;
            Console.WriteLine("Introduceti numerele din secventa:\n(dupa fiecare numar apasati tasta Enter)");
            for (int i = 0; i < n; i++)
            {
                int k = int.Parse(Console.ReadLine());
                if (k == a)
                {
                    Console.WriteLine($"Numarul {a} se afla pe a {i} a pozitie");
                    ok = true;
                }
            }
            if (ok == false)
            {
                Console.WriteLine($"Elementul {a} se afla pe pozitia -1");
            }
            Console.ReadKey();
        }

        private static void P5()
        {
            Console.WriteLine("\nProblema 5");
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine()), rsp = 0;
            Console.WriteLine("Introduceti numerele din secventa:\n(dupa fiecare numar apasati tasta Enter)");
            for (int i = 0; i < n; i++)
            {
                int k = int.Parse(Console.ReadLine());
                if (k == i)
                {
                    rsp++;
                }
            }
            Console.WriteLine(rsp);
            Console.ReadKey();
        }

        private static void P6()
        {
            Console.WriteLine("\nProblema 6");
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine()), aux = 0, okCounter = 0, forCounter = 0;
            Console.WriteLine("Introduceti numerele din secventa:\n(dupa fiecare numar apasati tasta Enter)");
            for (int i = 0; i < n; i++)
            {
                forCounter++;
                int k = int.Parse(Console.ReadLine());
                if (aux < k)
                {
                    okCounter++;
                }
                aux = k;
            }
            if (okCounter == forCounter)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            Console.ReadKey();
        }

        private static void P7()
        {
            Console.WriteLine("\nProblema 7");
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine()), minaux = int.MaxValue, maxaux = 0;
            Console.WriteLine("Introduceti numerele din secventa:\n(dupa fiecare numar apasati tasta Enter)");
            for (int i = 0; i < n; i++)
            {
                int k = int.Parse(Console.ReadLine());
                if (k < minaux)
                {
                    minaux = k;
                }
                if (k > maxaux)
                {
                    maxaux = k;
                }
            }
            Console.WriteLine($"Min value: {minaux}\nMax value: {maxaux}");
            Console.ReadKey();
        }

        private static void P8()
        {
            Console.WriteLine("\nProblema 8");
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());
            int x = 0, y = 1, z = 0;
            Console.WriteLine("Introduceti numerele din secventa:\n(dupa fiecare numar apasati tasta Enter)");
            for (int i = 2; i < n; i++)
            {
                z = x + y;
                x = y;
                y = z;
            }
            Console.WriteLine(z);
            Console.ReadKey();
        }

        private static void P9()
        {
            Console.WriteLine("\nProblema 9");
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine()), aux = 0;
            bool type = true;

            Console.WriteLine("Introduceti numerele din secventa:\n(dupa fiecare numar apasati tasta Enter)");
            for (int i = n; i > 0; i--)
            {
                int k = int.Parse(Console.ReadLine());
                if (k < aux)
                    type = false;
                aux = k;
            }
            if (type == false) { Console.WriteLine("Descrescatoare"); }
            else { Console.WriteLine("Crescatoare"); }
            Console.ReadKey();
        }

        private static void P10()
        {
            Console.WriteLine("\nProblema 10");
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());
            int k = 0, c1 = 1, aux = k, caux = 0;
            bool firstTime = true;
            Console.Write("Introduceti numerele din secventa\n(dupa fiecare numar apasati tasta Enter)");
            for (int i = n; i > 0; i--)
            {
                aux = k;
                k = int.Parse(Console.ReadLine());
                if (k == aux && firstTime == false)
                {
                    c1++;
                }
                else if (k != aux && c1 > caux && firstTime == false)
                {
                    caux = c1;
                    c1 = 1;
                }
                firstTime = false;
            }
            if (c1 > caux)
                Console.WriteLine($"Numarul maxim de numere consecutive egale este {c1}");
            else
                Console.WriteLine($"Numarul maxim de numere consecutive egale este {caux}");
            Console.ReadKey();
        }

        private static void P11()
        {
            Console.WriteLine("\nProblema 11");
            Console.WriteLine("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());
            int s = 0;
            Console.WriteLine("Introduceti numerele din secventa\n(dupa fiecare numar apasati tasta Enter)");
            for (int i = n; i > 0; i--)
            {
                int k = int.Parse(Console.ReadLine());
                s = s + (k % 10) * 10 + (k / 10);
            }
            Console.WriteLine($"Suma inverselor numerelor din secventa este {s}");
            Console.ReadKey();
        }

        private static void P12()
        {
            Console.WriteLine("\nProblema 12");
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numerele din secventa\n(dupa fiecare numar apasati tasta Enter)");
            int groups = 0;
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < n - 1; i++)
            {
                int y = int.Parse(Console.ReadLine());
                if (x != 0 && y == 0)
                    groups++;
                x = y;
            }
            Console.WriteLine($"Sunt {groups} grupuri de numere consecutive");
            Console.ReadKey();
        }

        private static void P13()
        {
            Console.WriteLine("\nProblema 13");
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numerele din secventa\n(dupa fiecare numar apasati tasta Enter)");
            int primul = int.Parse(Console.ReadLine());
            int ultimul = primul;
            int descrescator = 0;
            for (int i = 0; i < n - 1; i++)
            {
                int curent = int.Parse(Console.ReadLine());
                if (curent < ultimul || curent == ultimul)
                {
                    descrescator++;
                }
                ultimul = curent;
            }
            if (ultimul > primul)
                descrescator++;
            if (descrescator == 1 || descrescator == 0)
                Console.WriteLine("Secventa poate fi o secventa crescatoare rotita");
            else
                Console.WriteLine("Secventa nu poate fi o secventa crescatoare rotita");
            Console.ReadKey();
        }

        private static void P14()
        {
            Console.WriteLine("\nProblema 14");
        }

        private static void P15()
        {
            Console.WriteLine("\nProblema 15");
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());
            int dir = 0;
            int newdir = 0;
            Console.WriteLine("Introduceti numerele din secventa\n(dupa fiecare numar apasati tasta Enter)");
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < n - 1; i++)
            {
                int y = int.Parse(Console.ReadLine());
                if (y >= x)
                {
                    if (newdir != -1 || y == x)
                        dir = 1;
                    else
                    {
                        dir = 0;
                        break;
                    }
                }
                else
                    if (y <= x)
                {
                    newdir = -1;
                }
                x = y;
            }
            if (dir != 0)
                Console.WriteLine("Secventa este bitonica ");
            else
                Console.WriteLine("Secventa nu este bitonica ");
            Console.ReadKey();
        }

        private static void P16()
        {
            Console.WriteLine("\nProblema 16");
        }

        private static void P17()
        {
            Console.WriteLine("\nProblema 17");
            Console.Write("Introduceti numarul n: ");
            int n = int.Parse(Console.ReadLine());
            int ok = 0;
            int inc = 0;
            int maxinc = 0;
            while (n != 0)
            {
                int x = int.Parse(Console.ReadLine());
                if (x == 0)
                {
                    ok++;
                    inc++;
                }
                else
                    if (x == 1)
                {
                    ok--;
                    inc--;
                }
                if (inc > maxinc)
                    maxinc = inc;
                n--;
                if (ok == -1)
                    break;
            }
            if (ok == 0)
                Console.WriteLine($"Este reprezentata o secventa de paranteze corecte si are nivelul maxim de incuibare {maxinc}");
            else
                Console.WriteLine("Nu este reprezentata o secventa de paranteze corecte ");
            Console.ReadKey();
        }
    }
}
