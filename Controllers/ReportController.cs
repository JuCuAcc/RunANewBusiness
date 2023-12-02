using EmployeeManagementSystem.Data;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Controllers
{
    public class ReportController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReportController(ApplicationDbContext context)
        {
            _context = context;
        }

        //public IActionResult TotalPayoutsPerEmployee()
        //{
        //    var employeePayouts = _context.Employees
        //        .FromSqlRaw("EXEC sp_GetTotalPayoutsPerEmployee")
        //        .ToList();
        //    return View(employeePayouts);
        //}

        //public IActionResult TotalPayoutsPerEmployeeType()
        //{
        //    var employeeTypePayouts = _context.Employees
        //        .FromSqlRaw("EXEC sp_GetTotalPayoutsPerEmployeeType")
        //        .ToList();
        //    return View(employeeTypePayouts);
        //}

        public IActionResult TotalPayoutsPerEmployee()
        {
            //var employeePayouts = _context.TotalPayoutsPerEmployee.ToList();
            var employeePayouts = _context.Employees.ToList();
            return View(employeePayouts);
        }

        public IActionResult TotalPayoutsPerEmployeeType()
        {
            //var employeeTypePayouts = _context.TotalPayoutsPerEmployeeType.ToList();
            var employeeTypePayouts = _context.Employees.ToList();
            return View(employeeTypePayouts);
        }

    }
}
