﻿using System;
class Zuco
{

    static void Main()
    {
        String Nome;
        int N1, N2, R3;

        Console.Write("Qual é o seu nome?: ");
        Nome = Console.ReadLine();

        Console.WriteLine("Olá {0}! Muito prazer em te conhecer", Nome);
        Console.Write("{0}, nos informe um número para a soma por favor?: ", Nome);
        N1 = int.Parse(Console.ReadLine());
        Console.Write("Ótimo! Agora nos informe o segundo número para a soma, por favor: ");
        N2 = int.Parse(Console.ReadLine());

        R3 = N1 + N2;

        Console.WriteLine("{0}, a soma de {1} e {2} é igual a: {3}", Nome, N1, N2, R3);




    }
}