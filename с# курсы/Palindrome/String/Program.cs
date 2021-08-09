using System;

namespace String
{
    class Program
    {
        static bool Palindrome(string line)
        {
            int start = 0;
            int end = line.Length - 1;
            while(start <= end)
            {
                while (line[start] == ' ')
                {
                    start += 1;
                }
                while (line[end] == ' ')
                {
                    end -= 1;
                }
                if(line[start] != line[end])
                {
                    return false;
                }
                start += 1;
                end -= 1;
            }
            return true;

        }
        static void SealPalindrome(bool palindrome)
        {
            if(palindrome)
            {
                Console.WriteLine("Строка является палиндромом");
            }
            else
            {
                Console.WriteLine("Строка не палиндром");
            }    
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string line = Console.ReadLine();
            SealPalindrome(Palindrome(line));
        }
    }
}
