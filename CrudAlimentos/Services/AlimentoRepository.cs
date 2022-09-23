using CrudAlimentos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CrudAlimentos.Services
{
    public class AlimentoRepository
    {
        public List<alimento> GetAll()
        {
            using (var db =  new AlimentoContext())
            {
                return db.Alimentos.ToList();
            }
        }

        internal void Create(alimento model)
        {
            using (var db = new AlimentoContext())
            {
                db.Alimentos.Add(model);
                db.SaveChanges();
            }
        }

        internal void Edit(alimento model)
        {
            using (var db = new AlimentoContext())
            {
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        internal void Delete(alimento model)
        {
            using (var db = new AlimentoContext())
            {
                db.Alimentos.Remove(model);
                db.SaveChanges();
            }
        }


    }
}