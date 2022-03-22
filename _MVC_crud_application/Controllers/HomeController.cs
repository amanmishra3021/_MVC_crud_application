using _MVC_crud_application.DB_Context_EF;
using _MVC_crud_application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _MVC_crud_application.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Company_1Entities obj = new Company_1Entities();
            var obj1=obj.employee_1.ToList();

            return View(obj1);
        }
        [HttpGet]
        public ActionResult About()
        {
            


            return View();
        }
        [HttpPost]
        public ActionResult About( employee ad)
        { 

            Company_1Entities obj = new Company_1Entities();
            employee_1 obj1 = new employee_1();
            obj1.id = ad.id;
            obj1.name = ad.name;
            obj1.email = ad.email;
            obj1.mobile = ad.mobile;
            obj1.city = ad.city;
            obj1.Department = ad.Deparment;
            if (ad.id == 0) {
                obj.employee_1.Add(obj1);
                obj.SaveChanges();

            }
            else
            {
                obj.Entry(obj1).State=System.Data.Entity.EntityState.Modified;
                obj.SaveChanges();
            }
            
            return View();
        }

        public ActionResult delete(int ID)
        {
            Company_1Entities obj = new Company_1Entities();
            var delte=obj.employee_1.Where(m=>m.id==ID).First();
            obj.employee_1.Remove(delte);
            obj.SaveChanges();


            return RedirectToAction("Index");
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult edit(int id)
        {
            employee mod=new employee();
            Company_1Entities ent= new Company_1Entities();

            var Editdata=ent.employee_1.Where(m=>m.id==id).First();

             mod.id= Editdata.id;
             mod.name = Editdata.name;
            mod.email = Editdata.email;
            mod.mobile = Editdata.mobile;
            mod.city = Editdata.city;
            mod.Deparment = Editdata.Department;


            return View("About",mod);
        }
    }
}