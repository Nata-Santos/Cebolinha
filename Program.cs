using System;

namespace Cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
           string cebolinha;
           Console.ForegroundColor = ConsoleColor.DarkCyan;
           Console.WriteLine();
           
           Console.WriteLine("Digite uma frase, Ela será reproduzida com a fala do Cebolinha");
           Console.WriteLine();
           Console.ForegroundColor = ConsoleColor.DarkGreen;
           cebolinha = Console.ReadLine();
           Console.WriteLine();
           Console.WriteLine($"{cebolinha.Replace("r", "l").Replace("rr", "l").Replace("R", "L").Replace("RR", "L")}");
           Console.ResetColor();    
        }
    }
}
