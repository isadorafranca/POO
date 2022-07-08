using System;
using System.Collections.Generic;
using System.Text;

namespace sistema_de_pedidos_aop2
{
    public class Loja
    {
        int lojaId { get; set; }
        public List<Pedido> ListaPedidos { get; set; }

        public Loja() 
        {
            //aqui estamos criando um objeto...poderíamos atribuir valores aqui
            ListaPedidos = new List<Pedido>();
        }
        
        List<Funcionario> ListaFuncionarios()
        {
            //Nos criamos uma instância de uma classe usando a palavra new para podermos definir/utilizar
            //as propriedades/atributos e comportamento do objeto.
            var lista = new List<Funcionario>();
            return lista;
        }
        void Menu() { }
        public void InserirPedido(Pedido p)
        {
            ListaPedidos.Add(p);
            //a
            //b
            //c
            //d
            //e
        }
        void BuscarPedido() { }
        void RemoverPedido() { }
    }
}
