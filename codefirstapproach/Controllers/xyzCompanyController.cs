using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using codefirstapproach.Models;


namespace codefirstapproach.Controllers
{
    public class xyzCompanyController : Controller
    {
		//establish the database connection with context class

		xyzContext db = new xyzContext();


		public ActionResult Index()
        {
			//for access the table with db
			db.emp.ToList();  
			db.Dept.ToList();
            return View();
        }
    }
}