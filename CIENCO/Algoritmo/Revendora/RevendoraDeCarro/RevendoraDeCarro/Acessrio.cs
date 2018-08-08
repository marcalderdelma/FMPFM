using System;
using System.Text;
using System.Globalization;

namespace RevendoraDeCarro
{
    class Acessrio : IComparable
    {
        public string nome { get; set; }
        public double preco { get; set; }

        public Acessrio(string nome, double preco)
        {
            this.nome = nome;
            this.preco = preco;
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(nome)
                   .Append(", Preço: ")
                   .Append(preco.ToString("F2",CultureInfo.InvariantCulture));
            return builder.ToString();
        }
        public int CompareTo(object obj)
        {
            Acessrio outro = (Acessrio) obj;
            int comp = nome.CompareTo(outro.nome);
            if (comp == -1)
            {
                return comp;
            }
            return -preco.CompareTo(outro.preco);
        }
    }
}
