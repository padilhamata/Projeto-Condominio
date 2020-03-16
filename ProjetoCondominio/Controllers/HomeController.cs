using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetoCondominio.Models;
using System.Web.Mvc;

namespace ProjetoCondominio.Controllers
{
    public class HomeController : Controller
    {
            Pessoa pessoa = new Pessoa();
        
            TesteEntities db = new TesteEntities();
        public ActionResult Index()
        {
            Console.WriteLine("Estou aqui");
            return View();
        }

        public void testaDados()
        {

            Console.WriteLine(pessoa.Login);
            Console.WriteLine(pessoa.Senha);
            Console.WriteLine("Estou aqui");
        }

        public ActionResult About()
        {
           
            
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}