using ClientCompanyData.Entities;
using ClientCompanyDataAccess.Employee;
using Microsoft.AspNetCore.Mvc;

namespace ClientCompanyController.Controller
{
    [ApiController]
    [Route("/employee")]
    internal class EmployeeController : ControllerBase
    {
        public readonly IEmployeeRepository _repository;

        public EmployeeController(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        [HttpGet(nameof(GetAllEmployee))]
        public async Task<IActionResult> GetAllEmployee()
        {
            var employees = new Employee { Name = "Raşit", SurName = "Eşdemir", Email = "Reşdemir@gmail.com", PNumber = 1237894565, Department = "Java" };
            await _repository.Create(employees);

            var firstemployee = await _repository.GetEmployee();

            var model = _repository.GetAll().ToList();
            return (IActionResult)model;
        }
    }
}
