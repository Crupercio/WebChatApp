using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreWebApp.Models
{
    public class ChatMessage
    {
        public Guid Id { get; set; }
        
         [Required]
        public string? UserName { get; set; } 
        [Required]
        public string? Message { get; set; } // The message content
        public DateTimeOffset Timestamp { get; set; }
    }
}