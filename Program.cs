using System;

namespace Exercicio_Heron
{
    class Program
    {
        static void Main(string[] args)
        {
            Double lado1, lado2, lado3, Result, Result2, Result3, Result4, Result5;

           Console.ForegroundColor = ConsoleColor.DarkBlue;
           Console.WriteLine("Digite abaixo o numero de cada lado, um por vez, para que seja possivel descobrir o perímetro, semiperímetro e a área do triangulo.");

           Console.WriteLine();
           Console.ForegroundColor = ConsoleColor.White;

           Console.WriteLine("digite o lado 1:");
           lado1 = Convert.ToDouble(Console.ReadLine());

           Console.WriteLine("digite o lado 2:");
           lado2 = Convert.ToDouble(Console.ReadLine());

           Console.WriteLine("digite o lado 3:");
           lado3 = Convert.ToDouble(Console.ReadLine());

           Result = lado1 + lado2 + lado3;
           Result2 = Result /2;

           Console.WriteLine($"O resultado do perimetro é: {Result}");
           Console.ForegroundColor = ConsoleColor.DarkBlue;
           Console.WriteLine("Digite qualquer tecla para continuar");
           Console.ForegroundColor = ConsoleColor.White;
           Console.ReadKey();

           Console.WriteLine($"O resultado do semiperimetro é: {Result2}");
        
           Console.ReadKey();
           Console.WriteLine();

           Console.WriteLine("Agora vamos calcular a área");
           Console.WriteLine();
           Console.WriteLine("Formula: A= √p(p - a)(p - b)(p - c)");
           Console.WriteLine();

           Console.WriteLine($"A= √{Result2}({Result2} - {lado1}) * ({Result2} - {lado2}) * ({Result2} - {lado3})");
           Console.WriteLine($"A= √{Result2} * {(Result2 - lado1) * (Result2 - lado2) * (Result2 - lado3)}");

           Result3 = (Result2 - lado1) * (Result2 - lado2) * (Result2 - lado3);
           Result4 = Result2 * Result3;
           
            Console.WriteLine($"A= √ {Result4}");
           Math.Sqrt(Result4);
           Result5 = Math.Sqrt(Result4);
           
           
           
           Console.WriteLine($"O resultado da área é: {Result5}");
        }
    }
}
