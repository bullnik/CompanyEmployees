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
            if (!_employeeService.GetEmployeeById(id, out Employee? employee)
                || employee is null)
            {
                return Error();
            }
            CurrentEmployeeViewModel currentEmployeeViewModel = new(employee,
                _employeeService.GetVacationsByEmployee(employee));
            return PartialView(currentEmployeeViewModel);
        }

        public IActionResult InsertVacation(int employeeId, int startYear, 
            int startMonth, int startDay, int durationInDays) 
        {
            DateTime startDate = new(startYear, startMonth, startDay);
            if (!_employeeService.InsertNewVacation(employeeId, startDate, 
                durationInDays, out Vacation? vacation) || vacation is null)
            {
                return Error();
            }
            VacationIntersectionsViewModel vacationIntersectionsViewModel = new(
                _employeeService.GetFirstGroup(vacation),
                _employeeService.GetSecondGroup(vacation),
                _employeeService.GetThirdGroup(vacation),
                _employeeService.GetVacationsWithoutIntersections(vacation));
            return PartialView("VacationIntersections", vacationIntersectionsViewModel);
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