using ClientCompanyCore.BaseEntity;

namespace ClientCompanyData.Entities
{
    public class CompanyEmployee : BaseEntity
    {
        public Guid Company_Id { get; set; }
        public Guid Employee_Id { get; set; }
        public Company Company { get; set; }
        public Employee Employee { get; set; }
    }
}
