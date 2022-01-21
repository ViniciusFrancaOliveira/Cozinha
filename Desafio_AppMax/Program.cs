using System;
using Desafio_AppMax.Entities;
using System.Collections.Generic;

namespace Desafio_AppMax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cozinha cozinhaMineira = new Cozinha(14, 20, "Cozinha Mineira", "Feijoada", new List<IAlimento>()
            {
                new Ingrediente("Feijão", new DateTime(2022, 1, 30)),
                new Ingrediente("Farinha", new DateTime(2022, 3, 10)),
                new Ingrediente("Arroz", new DateTime(2022, 1, 30)),
                new Ingrediente("Carne de Porco", new DateTime(2022, 2, 3)),
                new Ingrediente("Linguiça", new DateTime(2022, 2, 5))
            });

            Cozinha cozinhaChinesa = new Cozinha(14, 20, "Cozinha Chinesa", "Yakissoba", new List<IAlimento>()
            {
                new Ingrediente("Champgion", new DateTime(2022, 2, 5)),
                new Ingrediente("Brócolis", new DateTime(2022, 2, 3)),
                new Ingrediente("Macarrão", new DateTime(2022, 1, 30)),
                new Ingrediente("Carne", new DateTime(2022, 2, 5))
            });

            Console.WriteLine("Selecione uma cozinha para ver seus atributos: (Mineira ou Chinesa)");
            string cozinhaEscolhida = Console.ReadLine().ToLower();

            if (cozinhaEscolhida == "mineira") Console.WriteLine(cozinhaMineira);
            else Console.WriteLine(cozinhaChinesa);
        }
    }
}
