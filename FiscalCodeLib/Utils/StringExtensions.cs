using System;

namespace FiscalCodeLib.Utils
{
    public static class StringExtensions
    {
        public static string Replace(this string s, char oldChar, char newChar, int count)
        {
            if (count < 0)
            {
                throw new ArgumentException("The parameter count must be a non-negative integer.");
            }

            if (count == 0)
            {
                return s;
            }

            string temp = "";

            for (int i = 0; i < count; i++)
            {
                foreach (char letter in s)
                {
                    if (letter == oldChar)
                    {
                        int pos = s.IndexOf(letter);
                        temp = s.Remove(pos, 1);
                        temp = temp.Insert(pos, newChar.ToString());
                    }
                }
            }

            return temp;
        }
    }
}