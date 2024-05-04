using ClientCompanyBusiness.Repository;

namespace ClientCompanyDataAccess.Client
{
    internal interface IClientRepository : IRepository<ClientCompanyData.Entities.Client>
    {
        Task<string> GetClient();
    }
}
