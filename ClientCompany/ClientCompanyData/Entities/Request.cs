using ClientCompanyCore.BaseEntity;

namespace ClientCompanyData.Entities
{
    public class Request : BaseEntity
    {
        public string Description { get; set; }
        public int Employee_ID { get; set; }
        public int Company_ID { get; set; }

        public Employee Employee { get; set; }
        public Company Company { get; set; }

        public ICollection<RequestClient> RequestClients { get; set; }
    }
}
