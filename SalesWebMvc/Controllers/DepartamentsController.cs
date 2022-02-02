using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using System.Collections.Generic;

namespace SalesWebMvc.Controllers
{
    public class DepartamentsController : Controller
    {
        public IActionResult Index()
        {
            //instanciando Departaments e setando atributos
            //Para facilitar, é criado uma lista de objetos
            List<Departaments> list = new List<Departaments>();
            list.Add(new Departaments { Id = 1, Name = "Eletronics"} );
            list.Add(new Departaments { Id = 2, Name = "Fashion" });

            //passando a lista na view
            return View(list);
        }
    }
}
