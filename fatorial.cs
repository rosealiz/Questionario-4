using System;

public class fatorial
{
    public static void Main()
    {
        int numero, i;
        int fatorial = 1;
        
        Console.WriteLine ("Digite numero");
        numero = int.Parse(Console.ReadLine());
        
        for(i = numero; i > 1; i--)
        {
          fatorial = fatorial * i;
          Console.WriteLine ($"{fatorial}");
        }
    }
}
