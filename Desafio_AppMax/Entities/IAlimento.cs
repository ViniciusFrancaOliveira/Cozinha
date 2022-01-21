using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_AppMax.Entities
{
    public interface IAlimento
    {
        string Nome { get; set; }   
        DateTime DataDeValidade { get; set; }    
    }
}
