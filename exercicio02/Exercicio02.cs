using System;

class Exercicio02{
    public static void Main (string[] args){
        Console.WriteLine("Digite um número");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        if (numero1 > 0 ){
            Console.WriteLine("Número é Positivo");
        } else if (numero1 == 0){
            Console.WriteLine("Número Igual a zero");
        } else {
            Console.WriteLine("Número negativo")
        }
    }
}