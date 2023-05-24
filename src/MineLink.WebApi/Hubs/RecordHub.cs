using Microsoft.AspNetCore.SignalR;

namespace MineLink.WebApi.Hubs;

public class RecordHub : Hub
{
    public async Task SendMessage(string user, string message)
    {
        await Clients.All.SendAsync("ReceiveMessage", user, message);
    }
}