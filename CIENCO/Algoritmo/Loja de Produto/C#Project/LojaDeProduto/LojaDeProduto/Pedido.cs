using System;
using System.Collections.Generic;
using System.Globalization;

namespace LojaDeProduto
{
    class Pedido
    {
        public int codigo { get; set; }
        public DateTime data { get; set; }
        public List<ItemPedido> itens { get; set; }

        public Pedido(int codigo, int dia, int mes, int ano)
        {
            this.codigo = codigo;
            data = new DateTime(ano,mes,dia);
            itens = new List<ItemPedido>(); 
        }
        public double ValorTotal()
        {
            double soma = 0.0;
            for(int i = 0; i<itens.Count; i++)
            {
                soma = soma + itens[i].SubTotal();
            }
            return soma;
        }

        public override string ToString()

        {
            string S = "Pedido, "
                + codigo
                + " Data:" + data.Day + "/" + data.Month + "/" + data.Year + "\n Itens: ";
            for (int i = 0; i < itens.Count; i++)
            {
                S = S + itens[i]+ "\n";
            }
            S = S + "Total: " + ValorTotal().ToString("F2",CultureInfo.InvariantCulture);
            return S;
        }
    }
}
