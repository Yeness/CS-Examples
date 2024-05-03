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
    }
}
