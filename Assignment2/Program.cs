using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  The  Average  minimum and maximum :
            int[] no = { 8, 5, 12, 20, 18 };
            Console.WriteLine(" The average element :" + " " + no.Average());
            Console.WriteLine(" The small element :" + " " + no.Min());
            Console.WriteLine(" The large element :" + " " + no.Max());
            Console.ReadLine();



            // 10 marks ,The Total sum of all marks, Avg,min,max, ascending , descending order.
            int[] cs = { 8, 10, 12, 14, 20, 17, 22, 26, 13, 11 };
            Console.WriteLine(" The total sum of  ele :" + " " + cs.Sum());
            Console.WriteLine(" The avg ele :" + " " + cs.Average());
            Console.WriteLine(" The small ele :" + " " + cs.Min());
            Console.WriteLine("The large of ele: " + cs.Max());
            Array.Sort(cs);
            Console.WriteLine(" The array ascending order is ");
            foreach (int i in cs)
            {
                Console.WriteLine(i + " ");
            }
            Array.Reverse(cs);
            Console.WriteLine(" the array descending order is ");
            foreach (int i in cs)
            {
                Console.Write(i + " ");
            }


            // The word length is:
            Console.WriteLine(" Enter the word ");
            string str = Console.ReadLine();
            Console.WriteLine("String length : " + str.Length);


            //  The Reverse string is:
            Console.WriteLine(" enter the string ");
            string Orginal = Console.ReadLine();
            string Reverse = string.Empty;
            for (int i = Orginal.Length - 1; i >= 0; i--)
            {
                Reverse += Orginal[i];
            }
            Console.WriteLine(" Reverse string is : " + Reverse);


            // Both words is same or not:
            Console.WriteLine(" The  Enter the word 1 ");
            string s1 = Console.ReadLine();
            Console.WriteLine(" The Enter the word 2 ");
            string s2 = Console.ReadLine();
            if (s1 == s2)
            {
                Console.WriteLine("The Both words is same ");
            }
            else if (s2 != s1)
            {
                Console.WriteLine("The Both words is not  a same ");
            }


            //The given word is a palindrome or not:
            string str1, rev;
            Console.WriteLine("  The Enter the word is ");
            str1 = Console.ReadLine();
            char[] ch = str1.ToCharArray();
            Array.Reverse(ch);
            rev = new string(ch);
            bool b = str1.Equals(rev, StringComparison.OrdinalIgnoreCase);
            if (b == true)
            {
                Console.WriteLine("The word is  a palindrome");
            }
            else if (b == false)
            {
                Console.WriteLine("The word is not a palindrome ");
            }
            Console.ReadLine();
        }
    }
}
