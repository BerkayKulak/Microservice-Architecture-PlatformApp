namespace FreeCourse.Web.Models
{
    public class ClientSettings
    {
        public string WebClient { get; set; }
        public string WebClientForUser { get; set; }
    }

    public class Client
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
    }
}
