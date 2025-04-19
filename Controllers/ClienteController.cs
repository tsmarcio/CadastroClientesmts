using Microsoft.AspNetCore.Mvc;
using mts_create.Models;
using System.Collections.Generic;

namespace mts_create.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            var clientes = new List<Cliente>
            {
                new Cliente { Id = 1, Nome = "João Silva", Email = "joao@email.com" },
                new Cliente { Id = 2, Nome = "Maria Oliveira", Email = "maria@email.com" },
                new Cliente { Id = 3, Nome = "Carlos Santos", Email = "carlos@email.com" }
            };

            return View(clientes);
        }
    }
}