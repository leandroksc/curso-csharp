using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Integrar.Domain.Entities;
using Integrar.Mvc.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Integrar.Mvc.Controllers
{
    public class CarrinhoController : Controller
    {
        public IActionResult Index()
        {
            List<Produto> produtos = new List<Produto>();
            for (int i = 1; i <= 10; i++)
            {
                produtos.Add(new Produto()
                {
                    Nome = "Produto" + i,
                    Valor = 1.17M * i,
                    Estoque = i * 2,
                    Validade = DateTime.Now,
                    Ativo = i % 2 == 0
                });
            }

            CarrinhoViewModel model = new CarrinhoViewModel()
            {
                Produtos = produtos,
                TotalCarrinho = produtos.Sum(x => x.Valor),
                Mensagem = "Mensagem de teste"
            };

            return RedirectToAction(nameof(Checkout), model);

            //return View(model);
        }

        public IActionResult Checkout(CarrinhoViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("erro", "deu algum erro no model");
            }
            return View(model);
        }
    }
}
