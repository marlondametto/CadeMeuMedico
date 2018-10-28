﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadeMeuMedico.Controllers
{
    public class MensagensController : Controller
    {
        //
        // GET: /Mensagens/

        public ActionResult BomDia()
        {
            return Content("Bom dia... hoje você acordou cedo!");
        }

        public ActionResult BoaTarde()
        {
            return Content("Boa tarde... não durma na mesa do trabalho!");
        }

        public ActionResult Quemeomeuamorzinho()
        {
            return Content("<h1> A Ana é o seu amorzinho </h1>");
        }
    }
}
