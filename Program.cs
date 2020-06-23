using System;
using System.Collections.Generic;

namespace Aula23Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando a lista 
            List<Cartao> cartoes = new List<Cartao>();

            //Adicionando os cartões à lista
            cartoes.Add(new Cartao(1, "Marcelo", "123456", "MasterCard", "12/30", "123" ));
            cartoes.Add(new Cartao(2, "Marcelo", "654321", "Visa", "11/30", "321" ));
            cartoes.Add(new Cartao(3, "Marcelo", "789456", "Elo", "10/30", "456" ));
            cartoes.Add(new Cartao(4, "Marcelo", "987654", "Santander", "9/30", "654" ));

            Cartao Itaú = new Cartao();
            Itaú.Codigo = 1;
            Itaú.Titular = "Marcelo";
            Itaú.Numero = "123789";
            Itaú.Bandeira = "Itaú";
            Itaú.Vencimento = "8/30";
            Itaú.Cvv = "987";

            cartoes.Add(Itaú);

            //Mostrando os cartoes com foreach
            foreach(Cartao c in cartoes){
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" {c.Titular}, {c.Numero}, {c.Bandeira} ");
            Console.ResetColor();
        }
        
            //Removendo itens através do índice de array
            cartoes.RemoveAt(2);

            // Usamos expressão lambda para eliminar um registro
            cartoes.RemoveAll(y => y.Numero == "654321");

             // Varremos nossa lista depois que foi alterada
            foreach(Cartao c in cartoes)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($" {c.Titular}, {c.Numero}, {c.Bandeira} ");
                Console.ResetColor();
            }

    }
  }
}
