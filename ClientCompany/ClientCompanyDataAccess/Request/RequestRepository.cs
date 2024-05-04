using ClientCompanyBusiness.Repository;

namespace ClientCompanyDataAccess.Request
{
    internal class RequestRepository : GenericRepository<Request>, IRequestRepository
    {
        public RequestRepository(AddDbContext dbContext) : base(dbContext)
        {

        }

        public async Task<string> GetRequest()
        {
            return await GetAll.Select(x => x.Name).FirstOrDefaultAsync();
        }
    }
}
