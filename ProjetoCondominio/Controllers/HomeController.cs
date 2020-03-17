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

        
          
        public ActionResult Index()
        {
            Console.WriteLine("Estou aqui");
            return View();
        }

        [HttpPost]
        public ActionResult testaDados(Pessoa pessoa)
        {
            
            

            Console.WriteLine(pessoa.Login);
            Console.WriteLine(pessoa.Senha);
            Console.WriteLine(pessoa.Login);
            Console.WriteLine(pessoa.Senha);
            Console.WriteLine("Estou aqui");
           // return View();
          return  RedirectToAction("Index");
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