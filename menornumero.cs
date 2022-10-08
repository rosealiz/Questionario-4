using System;

public class menornumero
{
    public static void Main()
    {
        int numero = 10000; 
        int menornumero = 10000;
        
        Console.WriteLine("digite numeros do seu conjunto, para parar digite 0");
        
        while(numero != 0){
            
            Console.WriteLine ("digite numero");
            numero  = int.Parse(Console.ReadLine());
        if (numero == 0){
        break;
        }
        else if(numero < menornumero){
            menornumero = numero;
        }
        }
        Console.WriteLine($"o menor numero do conjunto e {menornumero}");
    }
}
