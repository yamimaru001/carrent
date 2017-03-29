using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace CarRental.Controllers
{
    public class UserController : Controller
    {
        public ActionResult CreateEmployee()
        {
            ViewBag.Message = " สร้าง ข้อมูลพนักงาน";

            return View();
        }

       
        
    }
}
