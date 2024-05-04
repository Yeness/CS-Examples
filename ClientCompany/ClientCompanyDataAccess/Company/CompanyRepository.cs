using ClientCompanyBusiness.Repository;
using ClientCompanyUtils.Context;
using Microsoft.EntityFrameworkCore;

namespace ClientCompanyDataAccess.Company
{
    internal class CompanyRepository : GenericRepository<ClientCompanyData.Entities.Company>, ICompanyRepository
    {
        public CompanyRepository(SqliteDbContext dbContext) : base(dbContext)
        {

        }

        public Task Create(ClientCompanyData.Entities.Company entity)
        {
            throw new NotImplementedException();
        }

        public async Task<string> GetCompany()
        {
            return await GetAll().Select(x => x.Guid.ToString()).FirstOrDefaultAsync();
        }

        public Task Update(int id, ClientCompanyData.Entities.Company entity)
        {
            throw new NotImplementedException();
        }

        IQueryable<ClientCompanyData.Entities.Company> IRepository<ClientCompanyData.Entities.Company>.GetAll()
        {
            throw new NotImplementedException();
        }

        Task<ClientCompanyData.Entities.Company> IRepository<ClientCompanyData.Entities.Company>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
