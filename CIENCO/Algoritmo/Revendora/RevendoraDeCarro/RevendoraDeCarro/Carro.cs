using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace RevendoraDeCarro
{
    class Carro : IComparable
    {
        public int codigo { get; set; }
        public string modelo { get; set; }
        public int ano { get; set; }
        public double precoBasico { get; set; }
        public Marca marca { get; private set; }
        public List<Acessrio> acessrios { get; set; }

        public Carro (int codigo, string modelo, int ano, double precoBasico, Marca marca)
        {
            this.codigo = codigo;
            this.modelo = modelo;
            this.ano = ano;
            this.precoBasico = precoBasico;
            this.marca = marca;
            acessrios = new List<Acessrio>();
        }

        public double PrecoTotal()
        {
            double precoTotal = precoBasico;
            for(int i = 0; i < acessrios.Count; i++)
            {
                precoTotal += acessrios[i].preco;
            }
            return precoTotal;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append(codigo)
                   .Append(", ")
                   .Append(modelo)
                   .Append(", Ano: ")
                   .Append(ano)
                   .Append(", Preço Básico: ")
                   .Append(precoBasico.ToString("F2",CultureInfo.InvariantCulture))
                   .Append(", Preço Total: ")
                   .Append(PrecoTotal().ToString("F2",CultureInfo.InvariantCulture))
                   .Append("\nAcessório(s):\n");
            for(int i = 0; i < acessrios.Count; i++)
            {
                builder.Append(acessrios[i]);
            }
                   
            return builder.ToString();
        }

        public int CompareTo(object obj)
        {
            Carro outro = (Carro)obj;
            int comp = modelo.CompareTo(outro.modelo);
            if (comp == -1)
            {
                return comp;
            }
            return -precoBasico.CompareTo(outro.precoBasico);
        }
    }
}
