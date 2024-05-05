using ClientCompanyBusiness.Repository;
using ClientCompanyUtils.Context;
using Microsoft.EntityFrameworkCore;

namespace ClientCompanyDataAccess.Company
{
    public class CompanyRepository : GenericRepository<ClientCompanyData.Entities.Company>, ICompanyRepository
    {
        public CompanyRepository(SqliteDbContext dbContext) : base(dbContext)
        {

        }

        public async Task Create(ClientCompanyData.Entities.Company entity)
        {
            await Create(entity);
        }

        public async Task<string> GetCompany()
        {
            return await GetAll().Select(x => x.Guid.ToString()).FirstOrDefaultAsync();
        }

        public async Task Update(int id, ClientCompanyData.Entities.Company entity)
        {
            await Update(id, entity);
        }
        public async Task Delete(int id)
        {
            await Delete(id);
        }

        IQueryable<ClientCompanyData.Entities.Company> IRepository<ClientCompanyData.Entities.Company>.GetAll()
        {
            return GetAll();
        }

        Task<ClientCompanyData.Entities.Company> IRepository<ClientCompanyData.Entities.Company>.GetById(int id)
        {
            return GetById(id);
        }
    }
}
