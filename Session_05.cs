using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DINHDUCMANH
{
    /* internal class Session_05
       {
           public static void swap(ref int a, ref int b)
           {
               int temp = a; a = b; b = temp;
           }
           public static void Main()
           {
               int a = 6; int b = 7;
               Console.WriteLine($"before call a= {a}, b= {b}");
               swap(ref a, ref b); Console.WriteLine($"after call a={a} b={b}");
               Console.ReadKey();
           }
       }
    */

    class Game_taixiu
    {
        static int rollDice()
        {
            Random rnd = new Random();
            int die_1 = rnd.Next(6) + 1;
            int die_2 = rnd.Next(6) + 1;
            int die_3 = rnd.Next(6) + 1;
            int sum_of_dice = die_1 + die_2 + die_3;
            return sum_of_dice;

        }
        public static void PlayOneround()
        {
            int com_dice = rollDice();
            Console.WriteLine("ban doan tai hay xiu <t/x>");
            String User_gussing = Console.ReadLine();
            if (User_gussing.ToUpper().Equals("T"))
            {
                if (com_dice >= 10)
                    Console.WriteLine("ban thang");
                else Console.WriteLine("ban thua");

            }
            else if (User_gussing.ToUpper().Equals("X"))
            {
                if (com_dice <= 10)
                    Console.WriteLine("ban thang");
                else
                    Console.WriteLine("ban thua");

            }
            else
            {
                Console.WriteLine("Vui long chon dung <t/x>");
            }
        }
        public static void game_engine()
        {
            do
            {
                PlayOneround();
                Console.WriteLine("ban co muon tiep tuc? <c/k>");
                string choice = Console.ReadLine();
                if (choice.ToUpper().Equals("K"))
                    break;
            }
            while (true);
            Console.WriteLine("99% so nguoi bo cuoc khi sap thang");
        }
        public static void Main()
        {
            game_engine();
        }


    }
    internal class Session_05
    {
        static int maxOfThreeNumbers(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }
        static void Main(string[] args)
        {
            int m = maxOfThreeNumbers(5, 2, 4);
            Console.WriteLine(m);
            Console.ReadKey();
        }
    }
    static bool isPrime(int Number)
    {
        if (Number < 2) return false;
        for (int i = 2; i < Number; i++) ;
        if (Number % int == 0) return false;
        return true;

    }
    static void printPrimeNumberUnderN (int n)
    { }
}




            
