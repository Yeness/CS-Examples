using ClientCompanyCore.BaseEntity;

namespace ClientCompanyData.Entities
{
    public class Company : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int PNumber { get; set; }
        public string Sector { get; set; }

        public Guid CompanyGuid { get; set; }
        public ICollection<Request> Requests { get; set; }
        public ICollection<ClientCompany> ClientCompanies { get; set; }
        public ICollection<CompanyEmployee> CompanyEmployees { get; set;}
    }
}
