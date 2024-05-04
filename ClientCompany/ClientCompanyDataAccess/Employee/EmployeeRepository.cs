using ClientCompanyBusiness.Repository;
using ClientCompanyUtils.Context;
using Microsoft.EntityFrameworkCore;

namespace ClientCompanyDataAccess.Employee
{
    internal class EmployeeRepository : GenericRepository<ClientCompanyData.Entities.Employee>, IEmployeeRepository
    {
        public EmployeeRepository(SqliteDbContext dbContext) : base(dbContext)
        {

        }

        public Task Create(ClientCompanyData.Entities.Employee entity)
        {
            throw new NotImplementedException();
        }

        public async Task<string> GetEmployee()
        {
            return await GetAll().Select(x => x.Guid.ToString()).FirstOrDefaultAsync();
        }

        public Task Update(int id, ClientCompanyData.Entities.Employee entity)
        {
            throw new NotImplementedException();
        }

        IQueryable<ClientCompanyData.Entities.Employee> IRepository<ClientCompanyData.Entities.Employee>.GetAll()
        {
            throw new NotImplementedException();
        }

        Task<ClientCompanyData.Entities.Employee> IRepository<ClientCompanyData.Entities.Employee>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
