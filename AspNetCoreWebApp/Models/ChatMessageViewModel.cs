namespace AspNetCoreWebApp.Models
{
    public class ChatMessageViewModel
    {
        public string? UserName { get; set; } // User who sent the message
        public string? Message { get; set; }  // Message content
        public string? FormattedTimestamp { get; set; } // Timestamp formatted as string
    }
}
