using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_10
{
    internal class CalculatingSum
    {
        public static void Sum(int K, out int coll, out int rez, out string chisla)
        {
            Random random = new Random();
            coll = 1;
            rez = random.Next(5, 10);
            chisla = "";
            int num;
            chisla += rez.ToString();
            chisla += ", ";
            do
            {
                num = random.Next(5, 10);
                rez += num;
                coll++;

                chisla += num.ToString();
                chisla += ", ";
            }
            while (rez <= K);
        }
    }
}
