using ClientCompanyBusiness.Repository;

namespace ClientCompanyDataAccess.Company
{
    internal interface ICompanyRepository : IRepository<Company>
    {
        Task<string> GetCompany();
    }
}
