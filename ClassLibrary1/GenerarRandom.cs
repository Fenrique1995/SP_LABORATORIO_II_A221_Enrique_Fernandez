using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class GenerarRandom
    {
        private static Random random = new Random();
        public static double DoubleAleatorio(int max, int min)
        {
            return random.Next(max, min);
        }
    }
}
