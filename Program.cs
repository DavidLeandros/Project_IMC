﻿using System;

namespace Project_IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite dua idade:");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Agora digite o seu peso:");
            float peso = (float) Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Agora digite sua altura:");
            float altura = (float) Convert.ToDouble(Console.ReadLine());

            float resultado = peso / (altura * altura);

            if(resultado < 18.5)
            {
                Console.WriteLine(nome+", " + idade + " anos: Seu IMC é " + Math.Round (resultado, 2));
            }
            else if(resultado >= 18 && resultado < 25)
            {
                Console.WriteLine(nome+", " + idade + " anos: Seu IMC é " + Math.Round (resultado, 2));
            }
            else if(resultado >= 25 && resultado < 30)
            {
                Console.WriteLine(nome+", " + idade + " anos: Seu IMC é " + Math.Round (resultado, 2));
            }
              else if(resultado >= 30)
            {
                Console.WriteLine(nome+", " + idade + " anos: Seu IMC é " + Math.Round (resultado, 2));
            }
        }
    }
}
