using System;
using System.Globalization;

namespace LojaDeProduto
{
    public class Produto : IComparable
    {
        private int codigo;
        public string descricao {get;set;}
        public double preco {get;set;}

        public Produto(int codigo, string descricao, double preco){
            this.codigo=codigo;
            this.descricao = descricao;
            this.preco = preco;
        }

        public override string ToString(){
            return codigo +
                ", "+
                descricao +
                ", "+
                preco;

        }

        public int CompareTo(object obj)
        {
            Produto outro = (Produto) obj;
            int result = descricao.CompareTo(outro.descricao);
            if(result !=0){
                return result;
            }else{
                return -preco.CompareTo(outro.preco);
            }
        }
    }
}
