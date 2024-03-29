﻿using System;

namespace NumberInString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            Console.WriteLine(NumberInString(Convert.ToInt32(Console.ReadLine())));
        }
        static string NumberInString(int number)
        {
            string[] ones = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] teens = { "ten", "eleven", "twelwe", "thirteen", "fourteen", "fiveteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tens = { "", "", "twenty", "thirty", "fourty", "fivety", "sixty", "seventy", "eighty", "ninety" };
            string hundred = "hundred";
            string[] orders = { "", "thousand", "million", "billion" };
            string result = " ";
            int numThree = 0;
            bool sign = true;
            if (number == 0)
            {
                result = "zero";
            }
            else if (number < 0)
            {
                number = -number;
                sign = false;
            }
            while (number > 0)
            {
                int three = number % 1000;
                int one = three % 10;
                int ten = three % 100 / 10;
                int hund = three / 100;
                string threeResult = "";

                if (hund == 0)
                {
                    if (ten == 0)
                    {
                        threeResult = ones[one];
                    }
                    else if(ten == 1)
                    {
                        threeResult = teens[one];
                    }
                    else if(ten > 1)
                    {
                        if(one == 0)
                        {
                            threeResult = tens[ten];
                        }
                        else if(one > 0)
                        {
                            threeResult = tens[ten] + ' ' + ones[one];
                        }
                    }
                }
                if (hund > 0 && hund < 10)
                {
                    if (ten == 0)
                    {
                        if(one == 0)
                        {
                            threeResult = ones[hund] + ' ' + hundred;
                        }
                        else if(one > 0)
                        {
                            threeResult = ones[hund] + ' ' + hundred + ' ' + ones[one];
                        }
                    }
                    else if(ten == 1)
                    {
                        threeResult = ones[hund] + ' ' + hundred + ' ' + teens[one];
                    }
                    else if(ten > 1)
                    {
                        if(one == 0)
                        {
                            threeResult = ones[hund] + ' ' + hundred + ' ' + tens[ten];
                        }
                        else if(one > 0)
                        {
                            threeResult = ones[hund] + ' ' + hundred + ' ' + tens[ten] + ' ' + ones[one];
                        }
                    }
                }
                if (three == 0)
                {
                    result = threeResult + result;
                }
                else if (numThree == 0)
                {
                    result = threeResult;
                }
                else
                {
                    result = threeResult + ' ' + orders[numThree] + ' ' + result;
                }
                numThree += 1;
                number /= 1000;
            }
            if (sign = false)
            {
                result = "minus" + ' ' + result;
            }
                return result;
        }
    }
}
