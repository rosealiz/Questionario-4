using System;

public class numeroigual
{
    public static void Main()
    {
        int numero;
        int numlista = 0;
        
        Console.WriteLine("digite o numero desejado");
        numero = int.Parse(Console.ReadLine());
        
        while(numero != 0){
            
            Console.WriteLine ("digite numero");
            numlista  = int.Parse(Console.ReadLine());
            
        if (numero == numlista){
        break;
        }
        
        }
        Console.WriteLine($"o numero {numlista} e igual ao primeiro numero lido");
    }
}
