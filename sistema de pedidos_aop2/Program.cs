using System;

namespace sistema_de_pedidos_aop2
{
    class Program
    {
        static void Main(string[] args)
        {
            var loja = new Loja();
            var pedido = new Pedido { PedidoId = 2 };
            //loja.ListaPedidos.Add(pedido);
            loja.InserirPedido(pedido);

            var pedido1 = new Pedido { PedidoId = 3};
            //loja.ListaPedidos.Add(pedido1);
            loja.InserirPedido(pedido1);

            foreach (var p in loja.ListaPedidos) {
                Console.WriteLine("Número do pedido: "+p.PedidoId);
            }

            var funcionario = new Funcionario();
            var gerente = new Gerente();
            var estagiario = new Estagiario();


           
        }
    }
}
