using ClientCompanyBusiness.Repository;

namespace ClientCompanyDataAccess.Request
{
    internal interface IRequestRepository : IRepository<Request>
    {
        Task<string> GetRequest();
    }
}
