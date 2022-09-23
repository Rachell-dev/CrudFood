using CrudAlimentos.Models;
using CrudAlimentos.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;

namespace CrudAlimentos.Controllers
{
    public class AlimentoController : Controller
    {

        public AlimentoRepository _repo;
        private object idalimento;

        public AlimentoController()
        {
            _repo = new AlimentoRepository();
        }
        
        
        
        // GET: Alimento
        public ActionResult Index()
        {
            var model = _repo.GetAll();
            return View(model);
        }

        // GET: Alimento/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Alimento/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Alimento/Create
        [HttpPost]
        public ActionResult Create(alimento model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repo.Create(model);
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("Index");
                }
               
            }
            catch(Exception Ex )
            {
                //log
            }
            return View(model);
        }

        // GET: Alimento/Edit/5
        public ActionResult Edit(int? IdAlimento)
        {
            if (IdAlimento == null)
                return RedirectToAction("Index", "Alimento");

            var alimentos = _repo.GetAll();
            var selectAlimento = alimentos.Where(c => c.IdAlimento == IdAlimento).FirstOrDefault();
            //Alimento oalimento.alimento.Where(c => c.IdAlimento == idalimento).FirstOrDefault();
            //_repo.Create(selectAlimento);



            return View(selectAlimento);
        }

        // POST: Alimento/Edit/5
        // [HttpPost]

        //public ActionResult Edit()
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return View();
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: Alimento/Delete/5
        public ActionResult Delete(int? IdAlimento)
        {
            if (IdAlimento == null)
                return RedirectToAction("Index", "Alimento");

            var alimentos = _repo.GetAll();
            var selectAlimento = alimentos.Where(c => c.IdAlimento == IdAlimento).FirstOrDefault();
            //Alimento oalimento.alimento.Where(c => c.IdAlimento == idalimento).FirstOrDefault();
            //_repo.Create(selectAlimento);



            return View(selectAlimento);
        }

        // POST: Alimento/Delete/5
        [HttpPost]
        public ActionResult Delete(int IdAlimento, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
