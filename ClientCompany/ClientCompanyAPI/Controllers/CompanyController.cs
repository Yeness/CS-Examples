using ClientCompanyData.Entities;
using ClientCompanyDataAccess.Company;
using Microsoft.AspNetCore.Mvc;

namespace ClientCompanyController.Controller
{
    [ApiController]
    [Route("/company")]
    public class CompanyController : ControllerBase
    {
        public readonly ICompanyRepository _repository;

        public CompanyController(ICompanyRepository repository)
        {
            _repository = repository;
        }

        [HttpGet(nameof(GetAllCompany))]
        public async Task<IActionResult> GetAllCompany()
        {
            var company = new Company { Name = "EKEA", Address = "Merkez/Kayseri", Email = "EKEA_official@gmail.com", PNumber = 1239637596, Sector = "Yazılım" };
            await _repository.Create(company);

            var firstCompany = await _repository.GetCompany();

            var model = _repository.GetAll().ToList();
            return (IActionResult)model;
        }
    }
}
