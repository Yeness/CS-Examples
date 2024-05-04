using ClientCompanyBusiness.Repository;

namespace ClientCompanyDataAccess.Company
{
    internal interface ICompanyRepository : IRepository<ClientCompanyData.Entities.Company>
    {
        Task<string> GetCompany();
    }
}
