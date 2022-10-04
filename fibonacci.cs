using System;

public class fibonacci
{
    public static void Main()
    {
        int numero = 1, i, limite;
        int numero1 = 0;
        int soma = 0;
        
        Console.WriteLine("digite numero");
        limite = int.Parse(Console.ReadLine());
        
        for(i = 1; i <= limite; i++)
        {
          soma = numero + numero1;
          numero1 = numero;
          numero = soma;
          
          Console.WriteLine ($"{soma}");
        }
    }
}
