namespace Qwips.Core.MultiCase
{
    public class MultiCaseConfiguration
    {
        public string Server { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int WebServiceID { get; set; }
        public bool AzureAd { get; set; }
        public string AzureAdTenant { get; set; }
        public string AzureAdAppId { get; set; }
    }
}


