using ClientCompanyBusiness.Repository;
using ClientCompanyUtils.Context;
using Microsoft.EntityFrameworkCore;

namespace ClientCompanyDataAccess.Client
{
    internal class ClientRepository : GenericRepository<ClientCompanyData.Entities.Client>, IClientRepository
    {
        public ClientRepository(SqliteDbContext dbContext) : base(dbContext)
        {

        }

        public Task Create(ClientCompanyData.Entities.Client entity)
        {
            throw new NotImplementedException();
        }

        public async Task<string> GetClient()
        {
            return await GetAll().Select(x => x.Guid.ToString()).FirstOrDefaultAsync();
        }

        public Task Update(int id, ClientCompanyData.Entities.Client entity)
        {
            throw new NotImplementedException();
        }

        IQueryable<ClientCompanyData.Entities.Client> IRepository<ClientCompanyData.Entities.Client>.GetAll()
        {
            throw new NotImplementedException();
        }

        Task<ClientCompanyData.Entities.Client> IRepository<ClientCompanyData.Entities.Client>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
