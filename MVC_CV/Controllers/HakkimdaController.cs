using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_CV.Models.Entity;
using MVC_CV.Repositories;

namespace MVC_CV.Controllers
{
    public class HakkimdaController : Controller
    {
        GenericRepository<TBL_About> repo = new GenericRepository<TBL_About>();
        [HttpGet]
        public ActionResult Index()
        {
            var hakkimda = repo.List();
            return View(hakkimda);
        }
        [HttpPost]
        public ActionResult Index(TBL_About p)
        {
            var t = repo.Find(x => x.ID == 1);
            t.Name = p.Name;
            t.Surname = p.Surname;
            t.Adress = p.Adress;
           t.Telephone = p.Telephone;
            t.Mail = p.Mail;
            t.Explanation = p.Explanation;
            t.Resim = p.Resim;

            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}