using ClientCompanyBusiness.Repository;
using ClientCompanyUtils.Context;
using Microsoft.EntityFrameworkCore;

namespace ClientCompanyDataAccess.Request
{
    public class RequestRepository : GenericRepository<ClientCompanyData.Entities.Request>, IRequestRepository
    {
        public RequestRepository(SqliteDbContext dbContext) : base(dbContext)
        {

        }

        public async Task Create(ClientCompanyData.Entities.Request entity)
        {
            await Create(entity);
        }

        public async Task<string> GetRequest()
        {
            return await GetAll().Select(x => x.Guid.ToString()).FirstOrDefaultAsync();
        }

        public Task Update(int id, ClientCompanyData.Entities.Request entity)
        {
            return Update(id, entity);
        }

        public Task Delete(int id)
        {
            return Delete(id);
        }

        IQueryable<ClientCompanyData.Entities.Request> IRepository<ClientCompanyData.Entities.Request>.GetAll()
        {
            return GetAll();
        }

        Task<ClientCompanyData.Entities.Request> IRepository<ClientCompanyData.Entities.Request>.GetById(int id)
        {
            return GetById(id);
        }
    }
}
