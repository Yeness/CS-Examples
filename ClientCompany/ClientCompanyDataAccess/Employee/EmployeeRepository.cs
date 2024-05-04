using ClientCompanyBusiness.Repository;

namespace ClientCompanyDataAccess.Employee
{
    internal class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(AddDbContext dbContext) : base(dbContext)
        {

        }

        public async Task<string> GetEmployee()
        {
            return await GetAll.Select(x => x.Name).FirstOrDefaultAsync();
        }
    }
}
