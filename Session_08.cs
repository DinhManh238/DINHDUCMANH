using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DINHDUCMANH
{
    internal class Session_08
    
    {
        // Function to input and print a string
        static void InputAndPrintString()
        {
            Console.Write("Nhap string: ");
            string str = Console.ReadLine();
            Console.WriteLine("Ban nhap: " + str);
        }

        // Function to find the length of a string without using library function
        static void FindLengthWithoutLibrary()
        {
            Console.Write("Nhap string de tim do dai: ");
            string str = Console.ReadLine();
            int length = 0;
            foreach (char c in str)
            {
                length++;
            }
            Console.WriteLine("Do dai cua string la: " + length);
        }

        // Function to separate individual characters of a string
        static void SeparateCharacters()
        {
            Console.Write("Nhap string: ");
            string str = Console.ReadLine();
            Console.WriteLine("Ki tu rieng la: ");
            foreach (char c in str)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
        }

        // Function to print individual characters in reverse order
        static void PrintReverseOrder()
        {
            Console.Write("Nhap string: ");
            string str = Console.ReadLine();
            Console.WriteLine("Ki tu theo thu tu nguoc la: ");
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i] + " ");
            }
            Console.WriteLine();
        }

        // Function to count total number of words in a string
        static void CountWords()
        {
            Console.Write("Nhap string: ");
            string str = Console.ReadLine();
            string[] words = str.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Tong so tu la" + words.Length);
        }

        // Function to compare two strings without using library functions
        static void CompareStrings()
        {
            Console.Write("Nhap string thu nhat: ");
            string str1 = Console.ReadLine();
            Console.Write("Nhap string thu hai: ");
            string str2 = Console.ReadLine();
            bool bangNhau = true;

            if (str1.Length != str2.Length)
            {
               bangNhau = false;
            }
            else
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    if (str1[i] != str2[i])
                    {
                        bangNhau = false;
                        break;
                    }
                }
            }
            if (bangNhau)
            {
                Console.WriteLine("Ca hai string bang nhau.");
            }
            else
            {
                Console.WriteLine("Ca hai string khong bang nhau.");
            }
        }
        // Function to count alphabets, digits, and special characters
        static void CountAlphabetsDigitsSpecialCharacters()
        {
            Console.Write("Nhap string: ");
            string str = Console.ReadLine();
            int chuCai = 0, chuSo = 0, kiTuDacBiet = 0;

            foreach (char c in str)
            {
                if (Char.IsLetter(c))
                    chuCai++;
                else if (Char.IsDigit(c))
                    chuSo++;
                else
                    kiTuDacBiet++;
            }

            Console.WriteLine("Alphabets: " + chuCai);
            Console.WriteLine("Digits: " + chuSo);
            Console.WriteLine("Special Characters: " + kiTuDacBiet);
        }

        // Function to count vowels and consonants
        static void CountVowelsConsonants()
        {
            Console.Write("Nhap string: ");
            string str = Console.ReadLine();
            int vowels = 0, consonants = 0;

            foreach (char c in str)
            {
                if (Char.IsLetter(c))
                {
                    if ("aeiouAEIOU".IndexOf(c) >= 0)
                        vowels++;
                    else
                        consonants++;
                }
            }

            Console.WriteLine("Vowels: " + vowels);
            Console.WriteLine("Consonants: " + consonants);
        }

        // Function to check if a given substring is present in the string
        static void CheckSubstringPresence()
        {
            Console.Write("Nhap string: ");
            string str = Console.ReadLine();
            Console.Write("Nhap substring de check: ");
            string substring = Console.ReadLine();

            if (str.Contains(substring))
            {
                Console.WriteLine("Substring xuat hien trong string.");
            }
            else
            {
                Console.WriteLine("Substring khong xuat hien trong string.");
            }
        }

        // Function to search for the position of a substring in a string
        static void FindSubstringPosition()
        {
            Console.Write("Nhap string: ");
            string str = Console.ReadLine();
            Console.Write("Nhap substring muon tim vi tri: ");
            string substring = Console.ReadLine();

            int vitri = str.IndexOf(substring);
            if (vitri != -1)
            {
                Console.WriteLine("Substring o vi tri: " + vitri);
            }
            else
            {
                Console.WriteLine("Khong tim thay substring");
            }
        }

        // Function to check if a character is an alphabet and its case
        static void CheckCharacter()
        {
            Console.Write("Nhap ki tu: ");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (Char.IsLetter(c))
            {
                if (Char.IsUpper(c))
                {
                    Console.WriteLine("Ki tu la chu cai viet hoa.");
                }
                else
                {
                    Console.WriteLine("Ki tu la chu cai viet thuong.");
                }
            }
            else
            {
                Console.WriteLine("Ki tu lkhong phai la chu cai.");
            }
        }

        // Function to count how many times a substring appears in a string
        static void CountSubstringOccurrences()
        {
            Console.WriteLine("Nhap string: ");
            string str = Console.ReadLine();
            Console.Write("Nhap substring: ");
            string substring = Console.ReadLine();

            int count = 0;
            int index = 0;

            while ((index = str.IndexOf(substring, index)) != -1)
            {
                count++;
                index += substring.Length;
            }

            Console.WriteLine("substring xuat hien " + count + " lan.");
        }




