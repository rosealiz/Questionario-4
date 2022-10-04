using System;

public class tabuada
{
    public static void Main()
    {
        int numero, i, produto; 
        
        Console.WriteLine ("Digite numero");
        numero = int.Parse(Console.ReadLine());
        
        for(i = 0; i <= 10; i++)
        {
          produto = numero * i;
          Console.WriteLine ($"{numero} x {i} = {produto}");
        }
    }
}
