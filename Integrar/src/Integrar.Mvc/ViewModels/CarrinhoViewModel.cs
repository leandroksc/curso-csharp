using Integrar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Integrar.Mvc.ViewModels
{
    public class CarrinhoViewModel
    {
        public IEnumerable<Produto> Produtos { get; set; }
        [Range(500, 2000)]
        public Decimal TotalCarrinho { get; set; }
        public string Mensagem { get; set; }
    }
}
