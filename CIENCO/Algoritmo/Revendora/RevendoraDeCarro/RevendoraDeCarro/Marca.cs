using System;
using System.Collections.Generic;
using System.Text;

namespace RevendoraDeCarro 
{
    class Marca : IComparable
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public string pais { get; set; }
        public List<Carro> carros { get; set; }

        public Marca(int codigo, string nome, string pais)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.pais = pais;
            carros = new List<Carro>();
        }
        public void addCarro(Carro c)
        {
            carros.Add(c);
            carros.Sort();
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(codigo)
                   .Append(", ")
                   .Append(nome)
                   .Append(", País: ")
                   .Append(pais)
                   .Append(", número de Carro: ")
                   .Append(carros.Count);
            return builder.ToString();
        }
        public int CompareTo(object obj)
        {
            Marca outra = (Marca)obj;
            int comp = nome.CompareTo(outra.nome);
            return comp;
        }
    }
}
