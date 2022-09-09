using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projAula0909
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo t;
            t = new Triangulo(3, 4, 5);

            Console.WriteLine("Lado 1: {0}", t.getL1());
            Console.WriteLine("Lado 2: {0}", t.getL2());
            Console.WriteLine("Lado 3: {0}", t.getL3());

            Console.WriteLine(t.ehRetangulo() ? 
                "É triângulo retângulo" : 
                "Não é triângulo retângulo");
        }
    }
}
