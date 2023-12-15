namespace mvno_admin.Models
{
    public class Users
    {
        public Users(string providerName, string hasCoverage, string isValidAddress, string remarks)
        {
            this.providerName = providerName;
            this.HasCoverage = hasCoverage;
            this.isValidAddress = isValidAddress;
            this.remarks = remarks;
        }
        public string providerName { get; set; }
        public string HasCoverage { get; set; }
        public string isValidAddress { get; set; }
        public string remarks { get; set; }
    }
}