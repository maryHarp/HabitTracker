using System;
using System.Collections.Generic;
using System.Text;

namespace StringExtensions
{
    public static class StringExtensions
    {
        public static int WordCount(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return 0;

            string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        public static string ReverseWord(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(words);
            return string.Join(" ", words);
        }

        public static bool IsPalindrome(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return true;

            string cleaned = "";
            foreach (char c in str.ToLower())
            {
                if (char.IsLetterOrDigit(c))
                {
                    cleaned += c;
                }
            }

            char[] charArray = cleaned.ToCharArray();
            Array.Reverse(charArray);
            string reversed = new string(charArray);

            return cleaned == reversed;
        }

        public static string FlipCasing(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            char[] chars = str.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                char c = chars[i];
                if (char.IsUpper(c))
                {
                    chars[i] = char.ToLower(c);
                }
                else if (char.IsLower(c))
                {
                    chars[i] = char.ToUpper(c);
                }
            }

            return new string(chars);
        }

    }
}
