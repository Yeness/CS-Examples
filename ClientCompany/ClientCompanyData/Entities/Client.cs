using ClientCompanyCore.BaseEntity;

namespace ClientCompanyData.Entities
{
    public class Client : BaseEntity
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; } 
        public int PNumber { get; set; }
        public string Sex { get; set; }
    }
}
