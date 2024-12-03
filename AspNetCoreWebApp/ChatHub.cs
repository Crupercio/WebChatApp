using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace AspNetCoreWebApp;

[Authorize]
public class ChatHub : Hub
{
   public async Task SendMessage(string message)
    {
        // Get the authenticated user's name
        var user = Context.User?.Identity?.Name;

        // Capture the current timestamp
        var timestamp = DateTimeOffset.UtcNow;

        // Send the message, user name, and timestamp to all connected clients
        await Clients.All.SendAsync("ReceiveMessage", user, message, timestamp);
    }
}
