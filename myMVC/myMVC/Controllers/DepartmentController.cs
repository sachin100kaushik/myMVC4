using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using myMVC.Models;

namespace myMVC.Controllers
{
    public class DepartmentController : Controller
    {
        //
        // GET: /Department/

        public ActionResult Index()
        {
            EmployeeContext employeecontext = new EmployeeContext();
            List<Department> departments=employeecontext.Departments.ToList();
            return View(departments);
        }

        
    }
}
