using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Question1
{
    public class Search
    {
        public static int position; // index position

        public static int Searching<T>(IEnumerable<T> searchArray, T SearchKey) where T :  IComparable<T>
        {
            position = 0;
            var resultV = 0;
            foreach (T i in searchArray)
            {
                if (SearchKey.CompareTo(i) == 0)
                {
                    resultV = 1;
                    break;
                }
                else
                {
                    resultV = -1;
                }
                position += 1;
            }

            return resultV;
        }

    }
}
