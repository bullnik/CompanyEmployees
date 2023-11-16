using CompanyEmployees.Models;
using CompanyEmployees.Models.Emploees;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CompanyEmployees.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public HomeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public IActionResult Index()
        {
            IndexViewModel viewModel = new(_employeeService.Employees, 
                _employeeService.Vacations);
            return View(viewModel);
        }

        public IActionResult CurrentEmployee(int id)
        {
            if (!_employeeService.GetEmployeeById(id, out Employee? employee))
            {
                return Error();
            }
            CurrentEmployeeViewModel currentEmployeeViewModel = new(employee,
                _employeeService.GetFirstGroup(),
                _employeeService.GetSecondGroup(),
                _employeeService.GetThirdGroup(),
                _employeeService.GetFourthGroup());
            return PartialView(currentEmployeeViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id 
                ?? HttpContext.TraceIdentifier });
        }
    }
}