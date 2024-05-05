using ClientCompanyBusiness.Repository;

namespace ClientCompanyDataAccess.Employee
{
    public interface IEmployeeRepository : IRepository<ClientCompanyData.Entities.Employee>
    {
        Task<string> GetEmployee();
    }
}
