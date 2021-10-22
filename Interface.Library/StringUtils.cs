using System;

namespace Interface.Library
{
    interface IManipulation
    {
        string reverse(string s);
    }

    interface IGet
    {
        char charAt(string s, int i);
    }

    interface Utils : IManipulation, IGet {}


    public partial class StringUtils : Utils
    {
        public string reverse(string s)
        {
            string r = "";
            for (int i = (s.Length - 1); i >= 0; i--)
            {
                r += s[i];
            }

            return r;
        }

        public char charAt(string s, int i)
        {
            return ((char) s[0]);
        }
    }
}