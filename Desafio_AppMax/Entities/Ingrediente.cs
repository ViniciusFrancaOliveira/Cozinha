﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_AppMax.Entities
{
    public class Ingrediente : IAlimento
    {
        public string Nome { get; set; }
        public DateTime DataDeValidade { get; set; }

        public Ingrediente() { }

        public Ingrediente(string nome, DateTime dataDeValidade)
        {
            Nome = nome;
            DataDeValidade = dataDeValidade;
        }

        public override string ToString()
        {
            return Nome + " vence em: " + DataDeValidade.ToString("dd/MM/yyyy");
        }
    }
}
