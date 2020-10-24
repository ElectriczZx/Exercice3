using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercice3
{
    class Rgen
    {
        Random rnd = new Random();

        public void getRandom()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Number: ", rnd.Next(1, 100));
            }
        }
}
}
