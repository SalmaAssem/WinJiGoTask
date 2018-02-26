using System;
using NUnit.Framework;
using System.Text;

namespace Training
{
    public static class RandomString
    {
        public static string GenerateRandomString(int length)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < length; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            return builder.ToString().ToLower();
        }
    }
}
