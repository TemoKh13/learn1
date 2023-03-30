using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn1
{
    public class TemukaMoqmedeba
    {
        public static int damtvleli = 0;

        public static void StaticAchkebisMoxsna()
        {
            Console.WriteLine("Temukam achkebu moixsna");
            damtvleli = damtvleli + 1;
        }

        public static void RamodenimeMoqmedeba()
        {
            StPornoebisYureba();

            damtvleli = damtvleli + 1;
        }

        private static void StPornoebisYureba()
        {
            Console.WriteLine("Yureba ragatsis");

            damtvleli = damtvleli + 1;
        }

        public void AchkebisMoxsna()
        {
            Console.WriteLine("Temukam achkebu moixsna");
            damtvleli = damtvleli + 1;
        }

        private void PornoebisYureba()
        {
            Console.WriteLine("Yureba ragatsis");
        }

        public int OriRicxvisDajameba(int x, int y)
        {
            damtvleli = damtvleli + 1;
            return x + y;
        }
    }
}
