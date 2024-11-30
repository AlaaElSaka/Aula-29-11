using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVendas.Model
{
    public class Model
    {
        public class Vendas
        {
            public int Id { get; set; }
            public string Produto { get; set; }
            public string Descricao { get; set; }
            public DateTime DataVenda { get; set; }
            public decimal Valor { get; set; }


        }
    }
}
