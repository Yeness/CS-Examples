using ClientCompanyCore.BaseEntity;

namespace ClientCompanyData.Entities
{
    public class ClientCompany : BaseEntity
    {
        public Guid Client_Id { get; set; }
        public Guid Company_Id { get; set; }
        public Client Client { get; set; }
        public Company Company { get; set; }
    }
}
