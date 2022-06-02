using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is given string a palindrome?");

            Console.WriteLine();

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"{args[i]} -> {CheckString(args[i])}");
            }
        }

        private static bool CheckString(string s)
        {
            bool IsPalindrome(string s)
            {
                int check = 0;

                for (int i = 0, j = s.Length - 1; i < s.Length; i++, j--)
                {
                    if (s[i] == s[j])
                    {
                        check++;
                    }
                }

                if (check == s.Length)
                {
                    return true;
                }

                return false;
            }

            if (s == null)
            {
                throw new ArgumentNullException();
            }

            if (s.Length < 2)
                return true;
            
            return IsPalindrome(s);
        }
    }
}
