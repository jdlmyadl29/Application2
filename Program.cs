using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment2
{
    class Program
    {
        public string calcularManzanas(int[] manzanas)
        {
            int a = 4;
            int[] array = new int[3];
            for (int i = 0; i < manzanas.Length; i++)
            {
                array[i] = manzanas[i] + a;
            }
 
            int nManzanas = 0;
            foreach(int lanzamiento in array)
            {
                if (lanzamiento >= 7 && lanzamiento <= 10)
                {
                    nManzanas++;
                }
            }

            return nManzanas.ToString();
            

        }

        public string calcularNaranjas(int[] naranjas)
        {
            int b = 12;
            int[] array = new int[3];
            for (int i = 0; i < naranjas.Length; i++)
            {
                array[i] = naranjas[i] + b;
            }

            int nNaranjas = 0;
            foreach (int lanzamiento in array)
            {
                if (lanzamiento >= 7 && lanzamiento <= 10)
                {
                    nNaranjas++;
                }
            }

            return nNaranjas.ToString();


        }
        static void Main(string[] args)
        {
            int[] manzanas = { 2, 3, -4 };
            int[] naranjas = { 3, -2, -4 };
            Program p1 = new Program();
            Console.WriteLine(p1.calcularManzanas(manzanas));
            Console.WriteLine(p1.calcularNaranjas(naranjas));
            Console.ReadKey();
        }
    }
}
