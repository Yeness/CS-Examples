using ClientCompanyCore.BaseEntity;

namespace ClientCompanyData.Entities
{
    public class RequestClient : BaseEntity
    {
        public Guid Request_Id { get; set; }
        public Guid Client_Id { get; set; }
        public Request Request { get; set; }
        public Client Client { get; set; }
    }
}
