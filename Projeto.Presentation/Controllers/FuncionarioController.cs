using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto.Presentation.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario/Cadastro
        public ActionResult Cadastro()
        {
            return View();
        }
    }
}