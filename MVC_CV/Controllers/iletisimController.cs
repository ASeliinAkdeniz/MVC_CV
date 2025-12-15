using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_CV.Models.Entity;
using MVC_CV.Repositories;

namespace MVC_CV.Controllers
{
    public class iletisimController : Controller
    {
        // GET: iletisim
        GenericRepository<TBL_Iletisim> repo = new GenericRepository<TBL_Iletisim>();
        public ActionResult Index()
        {
            var mesajlar = repo.List();
            return View(mesajlar);
        }
        
    }
}