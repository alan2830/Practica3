using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numlados;
            float medidalado, perimetro;

            Console.WriteLine("escriba el numero de los lados: ");
            numlados = Int32.Parse(Console.ReadLine());
            Console.WriteLine("escriba la medida de un lado: "); 
            medidalado = Single.Parse(Console.ReadLine());
            perimetro = numlados * medidalado; 

            Console.WriteLine("el perimetro es: {0}", perimetro);

                
                
        }
    }
}
