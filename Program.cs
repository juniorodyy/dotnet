﻿using System;

namespace console_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome;
            nome = "Instituto Ivoti";
            //Console.WriteLine("Hello World!");
            Console.WriteLine(nome);   

            Double valor = 2.2;
            Double quantidade = 6.234;
            Double resultado = valor * quantidade;
            Console.WriteLine(resultado);   

            Boolean maiorQueDez = resultado > 10;
            if (maiorQueDez) {
                System.Console.WriteLine("É maior que dez");
                }
                else{
                System.Console.WriteLine("É menor que dez");
                }
                Calculadora p = new Calculadora();
                System.Console.WriteLine(p.calculo(4,4));
        }
    }
}
