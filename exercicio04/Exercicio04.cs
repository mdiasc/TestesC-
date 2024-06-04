using   System;

class Exercicio04{
    public static void Main (string[] args){
        Console.WriteLine("Digite o lado número 1");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o lado número 2");
        int numero2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o lado número 3");
        int numero3 = Convert.ToInt32(Console.ReadLine());
        
        int soma = numero1 + numero2;
        
        if (soma > numero3){
            Console.WriteLine("é um triângulo válido");
        } else {
            Console.WriteLine("não é um triângulo válido");
        }
    }
}