using System;
class Zuco
{
     static void Main()
    {
        String Nome;
        double P1, P2, P3, T1, T2, T3; //A nota máxima de todas essas variaveis é 3.
        double F; //Forum vale 2.
        double T; //Tudo somado
        double R; // Resultado real
        double N1, N2, N3, N4, N5, N6, N7;
        double Média = 6;


        Console.Write("Por favor, nos informe seu nome: ");
            Nome = Console.ReadLine();
        Console.WriteLine("Olá {0}, seja bem-vindo!", Nome);
        Console.Write("{0}, nos informe a nota da prova especifica: ", Nome);
            P1 = (double.Parse) (Console.ReadLine());
        if (P1 > 3)
        {
            Console.WriteLine("A nota máxima dessa prova é 3.");
        }

        Console.Write("Agora nos informe a nota da prova ASI: ");
            P2 = (double.Parse) (Console.ReadLine());
        if (P2 > 3)
        {
            Console.WriteLine("A nota máxima dessa prova é 3.");
        }

        Console.Write("Certo, nos informe a nota da prova dissertativa: ");
            P3 = (double.Parse) (Console.ReadLine());
        if (P3 > 3)
        {
            Console.WriteLine("A nota máxima dessa prova é 3.");
        }

        Console.Write("Ótimo {0}, agora nos informe a nota do Trabalho 1: ", Nome);
            T1 = (double.Parse) (Console.ReadLine());
        if (T1 > 3)
        {
            Console.WriteLine("A nota máxima desse trabalho é 3.");
        }
        Console.Write("Agora nos informe a nota do trabalho 2: ");
            T2 = (double.Parse) (Console.ReadLine());
        if (T2 > 3)
        {
            Console.WriteLine("A nota máxima dessa prova é 3.");
        }
        Console.Write("Certo {0}, nos informe a nota do trabalho 3: ", Nome);
            T3 = (double.Parse) (Console.ReadLine());
        if (T3 > 3)
        {
            Console.WriteLine("A nota máxima do trabalho é 3.");
        }
        Console.Write("Perfeito! Nos informe agora a nota do Forum: ");
            F = (double.Parse) (Console.ReadLine());
        if (F > 2)
        {
            Console.WriteLine("A nota máxima do forum é 2.");
        }
        T = P1 + P2 + P3 + T1 + T2 + T3 + F;
        R = T / 2;

        if (R >= Média)
        {
            Console.WriteLine("Parabéns {0}, sua nota totaL foi {1} e sua nota real foi {2}! Você foi APROVADO!", Nome, T, R);
        }
        else Console.WriteLine("Sinto muito {0}, sua nota total foi {1} e sua nota real foi {2}, você está REPROVADO!", Nome, T, R);

        
























    }
}
  
    

