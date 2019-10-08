using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintAlphabet();
            PrintAlphabet2();
            PrintAlphabetUP();
            ASCII('A');
            checkUpLow('b');
            change2('x');

        }
        public static void PrintAlphabet()
        {
            for (char c = 'a'; c <= 'z'; c++)
            {
                Console.Write(c);
            }

        }
        public static void PrintAlphabet2()
        {
            for (char c = 'z'; c >= 'a'; c--)
            {
                Console.WriteLine(c);
            }
        }
        public static void PrintAlphabetUP()
        {
            for (char c = 'A'; c <= 'Z'; c++)
            {
                Console.WriteLine(c);
            }
        }
        public static void ASCII(char c)
        {
            Console.WriteLine((int)c);
            for (int i = 65; i <= 122; i++)
            {
                if ((int)c == i)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void checkUpLow(char c)
        {
            for (int i = 65; i <= 90; i++)
            {
                if ((int)c == i)
                {
                    Console.WriteLine("{0} is UPPERCASE", c);
                }
            }


            for (int j = 97; j <= 122; j++)
            {
                if ((int)c == j)
                {
                    Console.WriteLine("{0} is LOWCASE", c);
                }
            }

        }
        public static void change(char c)
        {
            int chage = (int)c + 32;
            Console.Write((char)chage);
        }
        public static void change2(char c)
        {
            int chage = (int)c - 32;
            Console.Write((char)chage);
        }
    }
}


