using ClientCompanyCore.BaseEntity;

namespace ClientCompanyData.Entities
{
    public class Employee : BaseEntity
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public int PNumber { get; set; }
        public string Department { get; set; }

        public Guid EmployeeGuid { get; set; }
        public ICollection<Request> Requests { get; set;}
        public ICollection<CompanyEmployee> CompanyEmployees { get; set; }
    }
}
