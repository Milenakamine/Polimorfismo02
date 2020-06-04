using System;

namespace Polimorfismo02
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Anual: ");
          Anual anual = new Anual();
          anual.MostrarRelatorio();

            System.Console.WriteLine("Mensal: ");
          Mensal mensal = new Mensal();
          mensal.MostrarRelatorio();

           
        }
    }
}
