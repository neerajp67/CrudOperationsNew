using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoREPOSITORY;

namespace MvcDemo.Controllers
{
    public class NewController : Controller
    {
        // GET: New
        IDataAccess dataAccess = new DataAccessImplement();
        public ActionResult Index()
        {
           
            List<XpayModel> listModel = new List<XpayModel>();
            listModel = dataAccess.Read();
            return View(listModel);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new XpayModel());
        }
        [HttpPost]
        public ActionResult Create(XpayModel xPayModel)
        {
            dataAccess.Create(xPayModel);
            return RedirectToAction("Index");
        }
        public ActionResult Delete()
        {
            return View(new XpayModel());
        }
        [HttpPost]
        public ActionResult Delete(XpayModel xPayModel)
        {
            dataAccess.Delete(xPayModel);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Update()
        {
            return View(new XpayModel());
        }
        [HttpPost]
        public ActionResult Update(XpayModel xpayModel)
        {
          
            dataAccess.Update(xpayModel);

            return RedirectToAction("Index");
        }
    }
}