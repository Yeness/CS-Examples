using ClientCompanyBusiness.Repository;

namespace ClientCompanyDataAccess.Company
{
    public interface ICompanyRepository : IRepository<ClientCompanyData.Entities.Company>
    {
        Task<string> GetCompany();
    }
}
