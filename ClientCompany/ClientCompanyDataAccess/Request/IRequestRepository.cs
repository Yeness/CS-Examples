using ClientCompanyBusiness.Repository;

namespace ClientCompanyDataAccess.Request
{
    internal interface IRequestRepository : IRepository<ClientCompanyData.Entities.Request>
    {
        Task<string> GetRequest();
    }
}
