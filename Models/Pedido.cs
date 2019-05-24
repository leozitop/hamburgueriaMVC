using System;

namespace hamburgueriaMVC.Models
{
    public class Pedido
    {
        public ulong Id {get;set;}
        public Cliente cliente {get;set;}
        public Hamburguer Hamburguer {get;set;}
        public Shake Shake {get;set;}
        public DateTime DataPedido {get;set;}
    }
}