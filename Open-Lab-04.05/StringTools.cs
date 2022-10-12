using System;

namespace Open_Lab_04._05
{
    public class StringTools
    {
        public string Repeat(string orig, int n)
        {
            string sus = string.Empty;
            for(int i=0;i<orig.Length;i++)
            {
                for(int j=0;j<n;j++)
                {
                    sus += orig[i];
                }
            }
            return sus;
        }
    }
}
