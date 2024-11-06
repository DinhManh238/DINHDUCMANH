using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DINHDUCMANH
{
    internal class Session_03
    {
        
            public static void Main()
            {
                //Question_01();
                //Question_02();
                //Question_03();
                //Question_04();
                //Question_05();
                Question_06();
                Console.ReadKey();
            }
            public static void Question_01()
            {
                Console.Write("Nhap do C:");
                double c = double.Parse(Console.ReadLine());
                double f = c * 18 / 10 + 32;
                double k = c + 273;
                Console.Write($"f = {f}, k = {k}");
            }
            public static void Question_02()
            {
                Console.Write("Nhap ban kinh:");
                float r = float.Parse(Console.ReadLine());
                double s = 4 * Math.PI * Math.Pow(r, 2);
                double v = 4 / 3 * Math.PI * Math.Pow(r, 3);
                Console.Write($"s = {s}, v = {v}");
            }
            public static void Question_03()
            {
                Console.Write("Nhap so a:");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Nhap so b:");
                int b = int.Parse(Console.ReadLine());
                int c = a + b;
                int d = a - b;
                int e = a * b;
                int f = a / b;
                int g = a % b;
                Console.Write($"a + b = {c}, a - b = {d}, a * b = {e}, a / b = {f}, a % b = {g}");
            }

            //Cau 2: Write a C# Sharp program to display certain values of the function x = y2 + 2y + 1 (using integer numbers for y, ranging from - 5 to + 5).
            public static void Question_04()
            {
                Console.Write("Nhap y:");
                double y = double.Parse(Console.ReadLine());
                double x = Math.Pow(y, 2) + 2 * y + 1;
                Console.Write($"x = {x}");
            }
            //Cau 3: Write a C# Sharp program that takes distance and time (hours, minutes,seconds) as input and displays speed in kilometers per hour(km/h) and miles per hour(miles/h).

            public static void Question_05()
            {
                Console.Write("Nhap gio:");
                double g = double.Parse(Console.ReadLine());
                Console.Write("Nhap phut:");
                double p = double.Parse(Console.ReadLine());
                Console.Write("Nhap giay:");
                double s = double.Parse(Console.ReadLine());
                Console.Write("Nhap so km:");
                double km = double.Parse(Console.ReadLine());
                double c = (g + p / 60 + s / 3600) / km;
                Console.Write("Nhap so miles:");
                double miles = double.Parse(Console.ReadLine());
                double d = miles / g;
                Console.WriteLine($"Khoang cach km/h = c = {c}");
                Console.Write($"Khoang cach miles/h = d ={d}");
            }
            //Cau 5: Write a C# Sharp program that takes a character as input and checks if it is a vowel, a digit, or any other symbol.
            public static void Question_06()
            {
                Console.Write("Nhap mot ky tu:");
                char k = char.Parse(Console.ReadLine());
                // || la toan tu logic OR
                if ((k == 'u') || (k == 'e') || (k == 'o') || (k == 'a') || (k == 'i') || (k == 'U') || (k == 'E') || (k == 'O') || (k == 'A') || (k == 'I'))
                {
                    Console.Write("Do la nguyen am");
                }
                // && la toan tu logic AND
                else if ((k >= '0') && (k <= '9'))
                {
                    Console.Write("Do la chu so");
                }
                else Console.Write("La ky tu khac");
            }
        }

    }

