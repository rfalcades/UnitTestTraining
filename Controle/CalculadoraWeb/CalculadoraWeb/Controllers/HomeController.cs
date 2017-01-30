using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalculadoraWeb.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index(string valor1, string valor2)
        {
            ViewBag.Mensagem = "Valores Inválidos";
            int valorX;
            int valorY;
            bool isNumero1 = int.TryParse(valor1, out valorX);
            //bool isNumero2 = int.TryParse(valor2, out valorY);
            if (isNumero1)// && isNumero2)
            {
                ViewBag.Mensagem = "O valor é: " + (valorX + Convert.ToInt32(valor2));
            }
            return View();
        }

    }
}
