using System;

namespace Desafio_AppMax.Entities
{
    public interface IAlimento
    {
        string Nome { get; set; }   
        DateTime DataDeValidade { get; set; }    
    }
}
