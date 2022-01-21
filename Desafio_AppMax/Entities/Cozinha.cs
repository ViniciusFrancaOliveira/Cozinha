using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_AppMax.Entities
{
    public class Cozinha
    {
        public int HoraDeAbertura { get; set; }
        public int HoraDeFechamento { get; set; }
        public string NomeDaCozinha { get; set; }
        public string PratoPrincipal { get; set; }
        public List<IAlimento> Ingrediente { get; set; }

        public Cozinha() { }

        public Cozinha(int horaDeAbertura, int horaDeFechamento, string nomeDaCozinha, string pratoPrincipal, List<IAlimento> ingrediente)
        {
            HoraDeAbertura = horaDeAbertura;
            HoraDeFechamento = horaDeFechamento;
            NomeDaCozinha = nomeDaCozinha;
            PratoPrincipal = pratoPrincipal;
            Ingrediente = ingrediente;
        }

        public int ContagemIngredientes()
        {
            return this.Ingrediente.Count;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Bem-vindo " + NomeDaCozinha);
            sb.AppendLine("Abrimos às " + HoraDeAbertura);
            sb.AppendLine("Fechamos às " + HoraDeFechamento);
            sb.AppendLine("Temos os seguintes ingredientes: \n");

            for (int i = 0; i < ContagemIngredientes(); i++)
            {
                sb.AppendLine("   * " + Ingrediente[i].Nome);
            }

            return sb.ToString();
        }
    }
}
