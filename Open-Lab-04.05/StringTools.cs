using System;

namespace Open_Lab_04._05
{
    public class StringTools
    {
        public string Repeat(string orig, int n)
        {
            string r = "";
            for (int i = 0; i < orig.Length; i++)
            {
                for (int l = 0; l < n; l++)
                {
                    r = r + orig[i];
                }
            }
            return r;
        }
    }
}
