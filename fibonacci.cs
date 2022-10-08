using System;

public class fibonacci
{
    public static void Main()
    {
        int numero = 1, i, limite;
        int numero1 = 0;
        int soma = 1;
        
        Console.WriteLine("digite numero");
        limite = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"{soma}");
        for(i = 1; i <= (limite - 1); i++)
        {
          soma = numero + numero1;
          numero1 = numero;
          numero = soma;
          
          Console.WriteLine ($"{soma}");
        }
    }
}
