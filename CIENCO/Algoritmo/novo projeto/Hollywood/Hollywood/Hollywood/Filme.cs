using System.Text;
using System.Collections.Generic;
using System.Globalization;

namespace Hollywood
{
    class Filme
    {
        public int codigo { get; set; }
        public string titulo { get; set; }
        public int ano { get; set; }
        public List<Participacao> participacao { get; set; }
        
        public Filme(int codigo, string titulo, int ano )
        {
            this.codigo = codigo;
            this.titulo = titulo;
            this.ano = ano;
            participacao = new List<Participacao>();
        }
        public double CustoTotal()
        {
            double custoTotal = 0.0;
            for (int i = 0; i < participacao.Count; i++)
            {
                custoTotal = custoTotal + participacao[i].Custo();
            }
            return custoTotal;
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Filme: ").Append(codigo.ToString())
                .Append(", Titulo: ").Append(titulo)
                .Append("Ano: ").Append(ano.ToString())
                .Append("\nParticipações(ões): ");
            for (int i = 0; i < participacao.Count; i++)
            {
                builder.Append(participacao[i])
                       .Append("\n");

            }
            builder.Append("Custo Total: ")
                   .Append(CustoTotal().ToString("F2", CultureInfo.InvariantCulture));
            return builder.ToString();
        }
    }
}
