using ClientCompanyBusiness.Repository;

namespace ClientCompanyDataAccess.Client
{
    public interface IClientRepository : IRepository<ClientCompanyData.Entities.Client>
    {
        Task Create(ClientCompanyData.Entities.Employee employees);
        Task<string> GetClient();
    }
}
