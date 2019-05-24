using Microsoft.Extensions.Primitives;

namespace hamburgueriaMVC.Models
{
    public class Hamburguer
    {
        public string Nome {get;set;}

        public Hamburguer(string Nome)
        {
            this.Nome = Nome;
        }
    }
}