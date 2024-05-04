using ClientCompanyBusiness.Repository;

namespace ClientCompanyDataAccess.Company
{
    internal class CompanyRepository : GenericRepository<Company>, ICompanyRepository
    {
        public CompanyRepository(AddDbContext dbContext) : base(dbContext)
        {

        }

        public async Task<string> GetCompany()
        {
            return await GetAll.Select(x => x.Name).FirstOrDefaultAsync();
        }
    }
}
