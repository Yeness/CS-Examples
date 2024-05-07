using ClientCompanyData.Entities;
using ClientCompanyDataAccess.Request;
using Microsoft.AspNetCore.Mvc;

namespace ClientCompanyController.Controller
{
    [ApiController]
    [Route("/request")]
    public class RequestController : ControllerBase
    {
        public readonly IRequestRepository _repository;

        public RequestController(IRequestRepository repository)
        {
            _repository = repository;
        }

        [HttpGet(nameof(GetAllRequest))]
        public async Task<IActionResult> GetAllRequest()
        {
            var request = new Request {Description = "ClientCompanyAPI", Company_ID = 1, Employee_ID = 1};
            await _repository.Create(request);

            var firstRequest = await _repository.GetRequest();

            var model = _repository.GetAll().ToList();
            return (IActionResult)model;
        }
    }
}
