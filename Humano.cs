using System;

namespace console_dotnet
{
    class Humano 
    {
        public void randomicos(int a, int b)
        {
          Random t = new Random();
          int j = t.Next(a, b);
          int u = t.Next(a, b);
          int soma = j + u;         
          System.Console.WriteLine(j + "+" + u);

          int resp = Convert.ToInt32(Console.ReadLine());

          if (resp == soma) {
              System.Console.WriteLine("Acesso liberado");
            }
            else {
                System.Console.WriteLine("Acesso negado");
            }
        }
    }
}