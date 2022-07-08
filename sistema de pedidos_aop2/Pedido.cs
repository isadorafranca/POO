using System;
using System.Collections.Generic;
using System.Text;

namespace sistema_de_pedidos_aop2
{
   public class Pedido
    {
        //Os métodos get; set; atribuem e visualizam um valor a uma propriedade da classe
       public int PedidoId { get; set; }

        Loja loja;
        int lojaId { get; set; }
       DateTime dataEmissao { get; set; }
       float valorDoProduto { get; set; }
       string descricaoDoProduto { get; set; }

        public Pedido() { }
        double calcularPrecoTotal() 
        {
        var total=250;
            return total;
        }

    }
}
