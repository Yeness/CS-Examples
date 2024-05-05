using ClientCompanyBusiness.Repository;

namespace ClientCompanyDataAccess.Request
{
    public interface IRequestRepository : IRepository<ClientCompanyData.Entities.Request>
    {
        Task<string> GetRequest();
    }
}
