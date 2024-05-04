using ClientCompanyBusiness.Repository;
using ClientCompanyUtils.Context;
using Microsoft.EntityFrameworkCore;

namespace ClientCompanyDataAccess.Request
{
    internal class RequestRepository : GenericRepository<ClientCompanyData.Entities.Request>, IRequestRepository
    {
        public RequestRepository(SqliteDbContext dbContext) : base(dbContext)
        {

        }

        public Task Create(ClientCompanyData.Entities.Request entity)
        {
            throw new NotImplementedException();
        }

        public async Task<string> GetRequest()
        {
            return await GetAll().Select(x => x.Guid.ToString()).FirstOrDefaultAsync();
        }

        public Task Update(int id, ClientCompanyData.Entities.Request entity)
        {
            throw new NotImplementedException();
        }

        IQueryable<ClientCompanyData.Entities.Request> IRepository<ClientCompanyData.Entities.Request>.GetAll()
        {
            throw new NotImplementedException();
        }

        Task<ClientCompanyData.Entities.Request> IRepository<ClientCompanyData.Entities.Request>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
