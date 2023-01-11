using Newtonsoft.Json;

namespace ContactsSync.Model
{
    public class AllContractsVM
    {
        public int Id { get; set; }
        [JsonProperty("Email")]
        public string? Email_Address { get; set; }
        [JsonProperty("FirstName")]
        public string? First_Name { get; set; }
        [JsonProperty(PropertyName = "MiddleName")]
        public string? Middle_Name { get; set; }
        [JsonProperty(PropertyName = "LastName")]
        public string? Last_Name { get; set; }
        public string? Email_Preference { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }
        public string? Country { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Cell_Phone { get; set; }
        public string? Company_Name { get; set; }
        public string? Job_Title { get; set; }
        public string? Business_Phone { get; set; }
        public string? Business_Fax { get; set; }
        public string? Business_Address { get; set; }
        public string? Business_City { get; set; }
        public string? Business_State { get; set; }
        public string? Business_Zip { get; set; }
        public string? Business_Country { get; set; }
        public string? Notes { get; set; }
        public DateTime Date_1 { get; set; }
        public DateTime Date_2 { get; set; }
        public string? Extra_3 { get; set; }
        public string? Extra_4 { get; set; }
        public string? Extra_5 { get; set; }
        public string? Extra_6 { get; set; }
        [JsonProperty(PropertyName = "CreatedDate")]
        public DateTime? Date_Created { get; set; }
        [JsonProperty(PropertyName = "UpdatedDate")]
        public DateTime? Date_Modified { get; set; }
        public string? Optin_IP { get; set; }

    }
}
