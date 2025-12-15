using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_CV.Models.Entity;
using MVC_CV.Repositories;

namespace MVC_CV.Controllers
{
    public class YetenekController : Controller
    {
        // GET: Yetenek
       
        GenericRepository<TBL_Yeteneklerim> repo = new GenericRepository<TBL_Yeteneklerim>();
        public ActionResult Index()
        {
            var yetenekler = repo.List();
            return View(yetenekler);
        }
        [HttpGet]
        public ActionResult YeniYetenek()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniYetenek(TBL_Yeteneklerim p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult YetenekSil(int id)
        {
            var yetenek = repo.Find(x=>x.ID==id);
            repo.TDelete(yetenek);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult YetenekDuzenle(int id)
        {
            var Yetenek = repo.Find(x => x.ID == id);
            return View(Yetenek);
        }
        [HttpPost]
        public ActionResult YetenekDuzenle(TBL_Yeteneklerim t)
        {
            var y = repo.Find(x => x.ID == t.ID);
            y.Skill = t.Skill;
            y.Oran = t.Oran;
            repo.TUpdate(y);
            return RedirectToAction("Index");
        }
    }
}