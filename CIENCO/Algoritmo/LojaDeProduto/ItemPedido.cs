using System;

namespace LojaDeProduto
{
    public class ItemPedido
    {
        public int quantidade {get; set;}
        public double porcentageDesconto {get; set;}
        public Produto produto {get; private set;}

        public  ItemPedido (int quantidade, double porcentageDesconto, Produto produto){
            this.quantidade = quantidade;
            this.porcentageDesconto = porcentageDesconto;
            this.produto = produto;
        }
        public static double subTotal(int quantidade, double porcentageDesconto, Produto produto){
            return produto.preco*quantidade*porcentageDesconto/100;
        }
        public override string ToString(){
            return quantidade+
            ", "+
            porcentageDesconto+
            ", "+
            produto;
        }
    }
}
