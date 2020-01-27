using System;
using System.Collections.Generic;
using System.Linq;

namespace LCRomanToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> numeralDict = new Dictionary<string, int>()
            {
                {"I", 1}, {"II", 2}, {"III", 3}, {"IV", 4}, {"V", 5}, {"VI", 6}, {"VII", 7}, {"VIII", 8}, {"IX", 9},
                {"X", 10}, {"XX", 20}, {"XXX", 30}, {"XL", 40}, {"L", 50}, {"LX", 60}, {"LXX", 70}, {"LXXX", 80}, {"XC", 90},
                {"C", 100}, {"CC", 200}, {"CCC", 300}, {"CD", 400}, {"D", 500}, {"DC", 600}, {"DCC", 700}, {"DCCC", 800}, {"CM", 900},
                {"M", 1000}, {"MM", 2000}, {"MMM", 3000}
            };

            Console.WriteLine(RomanToInt("MMCCXXII"));

            int RomanToInt(string s)
            {
                int intFromNumeral = 0;

                int currentLetter = 0;

                string substring = s[currentLetter].ToString();

                while (currentLetter < s.Length)
                {
                    int numToAdd = 0;

                    try
                    {
                        while (numeralDict.ContainsKey(substring))
                        {
                            numToAdd = numeralDict[substring];
                            currentLetter++;
                            substring += s[currentLetter];
                        }

                        substring = s[currentLetter].ToString();

                        intFromNumeral += numToAdd;

                    }
                    catch
                    {
                        intFromNumeral += numToAdd;
                    }
                }

                return intFromNumeral;
            }
        }
    }
}
