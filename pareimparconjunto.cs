using System;

public class pareimparconjunto
{
    public static void Main()
    {
        float numero = 0;
        int impar = 0, par = 0;
        
        Console.WriteLine("digite o seu conjunto de numeros e insira -1 para parar");
        
        while(numero != -1){
            
            Console.WriteLine ("digite numero");
            numero  = float.Parse(Console.ReadLine());
            
        if (numero == -1){
        break;
        }
        else if(numero % 2 == 0){
            par++;
        }
        else{
            impar++;
        }
        }
    Console.WriteLine($"a quantidade de numeros pares e {par}");
    Console.WriteLine($"a quantidade de numeros impares e {impar}");
    }
}
