namespace ContactsSync.Model
{

    public class Rootobject
    {
        public Response Response { get; set; }
    }

    public class Response
    {
        public int Count { get; set; }
        public List<AllContractsVM> Data { get; set; }
        public object[] Errors { get; set; }
        public string Status { get; set; }
    }

    public class Datum
    {
        public string ClientZone { get; set; }
        public string ContactMasterID { get; set; }
        public string CreatedDate { get; set; }
        public string Email { get; set; }
        public string EmailType { get; set; }
        public string Filter { get; set; }
        public string FirstName { get; set; }
        public string ID { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Rating { get; set; }
        public string ReSend { get; set; }
        public string UpdatedDate { get; set; }
        public DateTime UpdatedDateTime { get; set; }
    }



}
