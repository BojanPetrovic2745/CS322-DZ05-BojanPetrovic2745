using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS322_DZ05_BojanPetrovic2745
{
    static class Pomocna
    {
        private static Random rnd = new Random();
        public static int GetRandomBroj()
        {
            
            int random = rnd.Next(1, 200);
            return random;
        }


        public static string GetRandomString()
        {
            
            string b = "abcdefghijklmnopqrstuvwxyz";

            string random = "";

            for (int i = 0; i < 8; i++)
            {
                int a = rnd.Next(8);
                random += b.ElementAt(a);

            }

            return char.ToUpper(random[0]) + random.Substring(1);
        }

    }
}

