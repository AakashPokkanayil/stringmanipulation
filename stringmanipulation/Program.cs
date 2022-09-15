using System;

namespace stringmanipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string op1;
            Console.WriteLine("Enter 1st String");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter 2st String");
            string str2 = Console.ReadLine();
            string op2 = flterstring(str1, str2, out op1);
            Console.WriteLine($"string 1 is {op1} and string 2 is {op2}");
            Console.ReadKey();
        }

        public static string flterstring(string s1,string s2,out string op1)
        {
            string op = "";
            if (string.IsNullOrEmpty(s1))
            {
                op1 = "";
                return s2;
            }
            if (string.IsNullOrEmpty(s2))
            {
                op1 = s1;
                return "";
            }
            for (int i = 0; i < s1.Length; i++)
            {
                if (!s2.ToLower().Contains(s1.ToLower()[i]))
                {
                    op += s1[i]; 
                }
            }
            op1=op;
            op = "";
            for (int i = 0; i < s2.Length; i++)
            {
                if (!s1.ToLower().Contains(s2.ToLower()[i]))
                {
                    op += s2[i];
                }
            }
            return op;

        }
    }
}
