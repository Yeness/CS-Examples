using ClientCompanyBusiness.Repository;

namespace ClientCompanyDataAccess.Employee
{
    internal interface IEmployeeRepository : IRepository<Employee>
    {
        Task<string> GetEmployee();
    }
}
