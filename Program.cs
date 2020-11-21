using System;

namespace codigo_regra_de_tres
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("A esta para B assim como C esta para X");
            Console.WriteLine("A");
            
            Console.WriteLine("A     B");
            Console.WriteLine("-  X  -");
            Console.WriteLine("C     X");

            Console.WriteLine("");
            Console.WriteLine("inserir valor de A");

                double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("inserir valor de B");

                double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("inserir valor de C");

                double num3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("O resultado é: " +  num3 * num2 / num1 );

            Console.WriteLine("Pressione qualquer tecla...");

            Console.ReadLine();
        }
    }
}
