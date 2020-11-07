using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS322_DZ05_BojanPetrovic2745
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Unesite broj za stepenovanje: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Unesite stepen broja");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Stepen je: " + stepen(a,b));

            Posetioc p1 = new Posetioc(Pomocna.GetRandomString(), Pomocna.GetRandomString(), Pomocna.GetRandomBroj());
            Posetioc p2 = new Posetioc(Pomocna.GetRandomString(), Pomocna.GetRandomString(), Pomocna.GetRandomBroj());

            p1.PrintPosetioc();
            p2.PrintPosetioc();

        }

        private static double stepen(double a, double b)
        {

            if(a != 0 && b >= 0)
            {
                return Math.Pow(a, b);
            }
            else
            {
                Console.WriteLine("Greška");
                return -1;
            }
        }

       
    }
}
