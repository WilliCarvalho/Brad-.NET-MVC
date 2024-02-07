using Microsoft.AspNetCore.Mvc;
using MVCSalesWebProj.Models;
using System.Collections.Generic;

namespace MVCSalesWebProj.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> departments = new List<Department>();
            departments.Add(new Department { Id = 1, Name = "Games" });
            departments.Add(new Department { Id = 2, Name = "Consoles" });
            return View(departments);
        }
    }
}
