using ClientCompanyBusiness.Repository;

namespace ClientCompanyDataAccess.Employee
{
    internal interface IEmployeeRepository : IRepository<ClientCompanyData.Entities.Employee>
    {
        Task<string> GetEmployee();
    }
}
