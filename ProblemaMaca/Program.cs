using System;
using System.Globalization;

namespace ProblemaMaca;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Seja bem vindo a minha quitanda, de uma olhada no preço das maçãs por favor.");
        Console.WriteLine("Uma maçã é R$ 1,30 e a partir da duzia sai por R$ 1,00");
        Console.WriteLine("Quantas maças você vai levar hoje ?");
        Console.WriteLine("Digite por favor a quantidade que v oce deseja comprar");

        double quantidade, ValorTotal;
        CultureInfo CI = CultureInfo.InvariantCulture;

        quantidade = int.Parse(Console.ReadLine());

        if(quantidade <= 11)
        {
            ValorTotal = quantidade * 1.30;
            Console.WriteLine("Valor total da compra = R$" + ValorTotal.ToString("F2", CI));
        }
        else if(quantidade >= 12)
        {
            ValorTotal = quantidade * 1.00;
            Console.WriteLine("Valor total da compra = R$" + ValorTotal.ToString("F2", CI));
        }

        

    }
}