using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WCFEmployeeMVC.EmployeeServiceReference;

namespace WCFEmployeeMVC.Controllers
{
    public class HomeController : Controller
    {
        EmployeeServiceReference.EmployeeServiceClient client = new EmployeeServiceReference.EmployeeServiceClient();

        public ActionResult Index()
        {
            
            return View(client.ListEmployee());
        }

        public ActionResult Details(int id)
        {
            var emp=client.ListEmployee().Where(s => s.ID == id).FirstOrDefault();
            return View(emp);
        }

        public ActionResult Edit(int id)
        {
            var emp = client.ListEmployee().Where(s => s.ID == id).FirstOrDefault();
            return View(emp);
        }

        public ActionResult Delete(int id)
        {
            var emp = client.ListEmployee().Where(s => s.ID == id).FirstOrDefault();
            return View(emp);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SaveChange(CEmployee nEmp)
        {
            client.UpdateEmployee(nEmp.ID,nEmp.Name,nEmp.HireDate,nEmp.Salary,1,nEmp.Address);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult SaveCreate(CEmployee nEmp)
        {
            client.CreateEmployee(nEmp.Name, nEmp.HireDate, nEmp.Salary, 1,nEmp.Address);
            return RedirectToAction("Index");
        }
        public ActionResult SaveDelete(int id)
        {
            client.DeleteEmployee(id);
            return RedirectToAction("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}