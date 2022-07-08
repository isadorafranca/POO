using System;
using System.Collections.Generic;
using System.Text;

namespace sistema_de_pedidos_aop2
{
    //Herança:criação de novas classes que reutilizam, estendem e modificam o comportamento definido em outras classes
    class Gerente :Funcionario
    {
        string senha { get; set; }
        double calcularDescontoMaior () 
        {
            var total = 250;
            return total;
        }
    }
}
