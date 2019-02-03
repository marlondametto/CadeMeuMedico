using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using CadeMeuMedico.Models;

namespace CadeMeuMedico.Controllers
{
    public class CidadesController : Controller
    {
        private EntidadesCadeMeuMedicoBD db = new EntidadesCadeMeuMedicoBD();
        //
        // GET: /Cidades/

        public ActionResult Index()
        {
            var cidades = from c in db.Cidades
                          select c;
            return View(cidades.ToList());
        }

        public ActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Adicionar(Cidades cidade)
        {
            if(ModelState.IsValid)
            {               
                db.Cidades.Add(cidade);
                db.SaveChanges();
                return RedirectToAction("index");                
            }
            return View(cidade);
        }

        public ActionResult Editar(long id)
        {
            Cidades cidade = db.Cidades.Find(id);
            return View(cidade);
        }

        [HttpPost]
        public ActionResult Editar(Cidades cidade)
        {
            if(ModelState.IsValid)
            {
                db.Entry(cidade).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("index");
            }
            return View(cidade);
        }

        [HttpPost]
        public string Excluir(long id)
        {
            try
            {
                Cidades cidade =db.Cidades.Find(id);
                db.Cidades.Remove(cidade);
                db.SaveChanges();
                return Boolean.TrueString;
            }
            catch
            { 
                return Boolean.FalseString;
            }
        }

    }
}
