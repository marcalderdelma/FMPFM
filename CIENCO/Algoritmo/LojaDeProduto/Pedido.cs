using System;
using System.Data;

namespace LojaDeProduto
{
    public class Pedido
    {
        public int codigo {get; set;}
        public int dia {get; set;}
        public int mes {get; set;}
        public int ano  {get; set;}
        public ItemPedido itemPedido {get; private set;}

        public Pedido( int codigo, int ano, int mes, int dia, ItemPedido itemPedido){
        this.codigo=codigo;
        this.ano=ano;
        this.mes=mes;
        this.dia=dia;
        this.itemPedido=itemPedido;
        }
        public static void ValorTotal(int codigo, int ano, int mes, int dia, ItemPedido itemPedido){
            new DateTime(ano,mes,dia);
            //return itemPedido.
            
        }
    }

}
