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
            //return View(aluno);
            //comentei por que depurei e vi que não muda nada passar o model aluno para a view CadastroAluno
            //é necessario instanciar o model ModAluno de qualquer maneira la CadastroAluno.cshtml

            return View("CadastroAluno");
        }

        [HttpPost]
        //recebe como parametro a variavel aluno do tipo ModAluno que foi instanciada em CadastroAluno.cs linha 1
        public ActionResult ExibeCadastroAlunoTIPADO(ModAluno aluno)
        {
            return View(aluno); //envia para a view ExibeCadastroAlunoTIPADO a instancia de modelo aluno
        }
    }
}