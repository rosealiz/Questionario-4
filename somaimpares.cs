using System;

public class somaimpares
{
    public static void Main()
    {
        int numero1, numero2, i; 
        int soma = 0;
        
        Console.WriteLine ("Digite numero1");
        numero1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine ("Digite numero2");
        numero2 = int.Parse(Console.ReadLine());
        
        for(i = numero1; i <= numero2; i++)
        {
            if(i % 2 != 0)
            {
             soma = soma + i;
             Console.WriteLine ($"{soma}");
            }
        }
        Console.WriteLine ($"O total da soma dos numeros impares e {soma}");
    }
}
