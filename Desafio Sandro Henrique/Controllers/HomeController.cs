using Desafio_Sandro_Henrique.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Desafio_Sandro_Henrique.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

    }
}