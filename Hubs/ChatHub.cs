using Microsoft.AspNetCore.SignalR;

namespace ChatAPI.Hubs
{
    public class ChatHub : Hub
    {
        public async Task StreamingMessage(string user, string message)
        {
            await Clients.All.SendAsync("StreamingMessage", user, message);
        }
    }
}
