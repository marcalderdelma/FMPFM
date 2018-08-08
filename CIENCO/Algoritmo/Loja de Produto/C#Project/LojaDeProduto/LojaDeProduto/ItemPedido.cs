using System;
using System.Collections.Generic;
using System.Globalization;


namespace LojaDeProduto
{
    class ItemPedido
    {
        public int quantidade { get; set; }
        public double porcentagemDesconto { get; set; }
        public Produto produto { get; private set; }
        

        public ItemPedido(int quantidade, double porcentagemDesconto, Produto produto) { 
            this.quantidade = quantidade;
            this.porcentagemDesconto = porcentagemDesconto;
            this.produto = produto;
            
        }
        public double SubTotal()
        {
            double desconto = produto.preco * porcentagemDesconto / 100;
            return (produto.preco - desconto) * quantidade;
        }
        public override string ToString()
        {
            return produto.descricao
                + ", Preco: "
                + produto.preco
                + ", Qte: "
                + quantidade
                + ", Desconto: "
                + porcentagemDesconto.ToString("F2",CultureInfo.InvariantCulture)
                + "%, SubTotal: "
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }

    }

}
