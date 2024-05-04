using ClientCompanyBusiness.Repository;

namespace ClientCompanyDataAccess.Client
{
    internal interface IClientRepository : IRepository<Client>
    {
        Task<string> GetClient();
    }
}
