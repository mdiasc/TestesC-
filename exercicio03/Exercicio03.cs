using System;

class Exercicio03{
    public static void Main (string[] args){
        Console.WriteLine("Digite um número:");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite mais um número:");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        if (numero1> numero2){
            Console.WriteLine("O maior entre os números é:" + numero1);
        } else {
            Console.WriteLine("O maior entre os números é:" + numero2);
        }
    }
}