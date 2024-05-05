using ClientCompanyBusiness.Repository;
using ClientCompanyUtils.Context;
using Microsoft.EntityFrameworkCore;

namespace ClientCompanyDataAccess.Client
{
    public class ClientRepository : GenericRepository<ClientCompanyData.Entities.Client>, IClientRepository
    {
        public ClientRepository(SqliteDbContext dbContext) : base(dbContext)
        {

        }

        public async Task Create(ClientCompanyData.Entities.Client entity)
        {
            await Create(entity);
        }

        public async Task<string> GetClient()
        {
            return await GetAll().Select(x => x.Guid.ToString()).FirstOrDefaultAsync();
        }

        public async Task Update(int id, ClientCompanyData.Entities.Client entity)
        {
            await Update(id, entity);
        }

        public async Task Delete(int id)
        {
            await Delete(id);
        }

        IQueryable<ClientCompanyData.Entities.Client> IRepository<ClientCompanyData.Entities.Client>.GetAll()
        {
            return GetAll();
        }

        Task<ClientCompanyData.Entities.Client> IRepository<ClientCompanyData.Entities.Client>.GetById(int id)
        {
            return GetById(id);
        }
    }
}
