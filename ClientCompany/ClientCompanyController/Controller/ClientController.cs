using Abp.Web.Mvc.Models;
using ClientCompanyData.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ClientCompanyController.Controller
{
    public class ClientController : Controller
    {
        private readonly IClientRepository _repository;
        public ClientController(IClientRepository repository)
        {
            _repository = repository;
        }

        public async Task<IActionResult> Index()
        {
            var client = new Client { Name = "Hakkı", SurName = "Bulut", Email = "hakkibulut@gmail.com", PNumber = 1234567899, Sex = "E"};
            await _repository.Create(client);

            var firstClient = await _repository.GetClient();

            var model = _repository.GetAll();

            return View(model);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContent.TraceIdentifier
            });
        }
    }
}
