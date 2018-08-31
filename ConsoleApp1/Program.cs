using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Calculo_do_IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, P, imc;

            Console.Write("Digite o seu peso:");
            P = int.Parse(Console.ReadLine());

           
            Console.Write("Digite o seu altura:");
            A = int.Parse(Console.ReadLine());
            
            imc = P * 10000  / (A * A);

            if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do peso " + imc);
            }
            else if ((imc > 18.5) && (imc < 25))
            {
                Console.WriteLine("Peso normal " + imc);
            }
            else if ((imc > 25) && (imc < 30))
            {
                Console.WriteLine("Sobre o Peso " + imc);
            }
            else if ((imc > 30) && (imc < 35))
            {
                Console.WriteLine("Grau de Obesidade I " + imc);
            }
            else if ((imc > 35) && (imc < 40))
            {
                Console.WriteLine("Grau de Obesidade II " + imc);
            }
            else if (imc > 40)
            {
                Console.WriteLine(("Grau de Obesidade II " + imc);
            }

            Console.ReadKey();
        }
    }
}