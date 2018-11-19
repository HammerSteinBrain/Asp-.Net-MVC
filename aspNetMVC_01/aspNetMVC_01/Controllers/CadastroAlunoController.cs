using aspNetMVC_01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspNetMVC_01.Controllers
{
    public class CadastroAlunoController : Controller
    {
        public ActionResult CadastroAluno() {

            //ModAluno aluno = new ModAluno();

            return View("CadastroAluno");
        }

        [HttpPost]
        public ActionResult ExibeCadastroAluno(FormCollection form) { 
        //recebe dados do form que foi criado na view CadastroAluno

            ViewBag.idAluno = form["idAluno"];
            ViewBag.Nome = form["Nome"];
            ViewBag.Email = form["Email"];
            
            return View("ExibeCadastroAluno");
        }
    }
}