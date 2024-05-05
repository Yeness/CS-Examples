using ClientCompanyBusiness.Repository;
using ClientCompanyUtils.Context;
using Microsoft.EntityFrameworkCore;

namespace ClientCompanyDataAccess.Employee
{
    public class EmployeeRepository : GenericRepository<ClientCompanyData.Entities.Employee>, IEmployeeRepository
    {
        public EmployeeRepository(SqliteDbContext dbContext) : base(dbContext)
        {

        }

        public async Task Create(ClientCompanyData.Entities.Employee entity)
        {
            await Create(entity);
        }

        public async Task<string> GetEmployee()
        {
            return await GetAll().Select(x => x.Guid.ToString()).FirstOrDefaultAsync();
        }

        public Task Update(int id, ClientCompanyData.Entities.Employee entity)
        {
            return Update(id, entity);
        }

        public Task Delete(int id)
        {
            return Delete(id);
        }

        IQueryable<ClientCompanyData.Entities.Employee> IRepository<ClientCompanyData.Entities.Employee>.GetAll()
        {
            return GetAll();
        }

        Task<ClientCompanyData.Entities.Employee> IRepository<ClientCompanyData.Entities.Employee>.GetById(int id)
        {
            return GetById(id);
        }
    }
}
