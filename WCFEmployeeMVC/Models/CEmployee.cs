using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFEmployeeMVC.Models
{
    public class CEmployee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public System.DateTime HireDate { get; set; }
        public int Salary { get; set; }
        public string DepartmentName { get; set; }
        public string Address { get; set; }

    }
}