using ClientCompanyBusiness.Repository;

namespace ClientCompanyDataAccess.Client
{
    internal class ClientRepository : GenericRepository<Client>, IClientRepository
    {
        public ClientRepository(AddDbContext dbContext) : base(dbContext)
        {

        }

        public async Task<string> GetClient()
        {
            return await GetAll.Select(x=>x.Name).FirstOrDefaultAsync();
        }
    }
}
