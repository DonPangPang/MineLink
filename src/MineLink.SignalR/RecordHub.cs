using Microsoft.AspNetCore.SignalR;
using MineLink.Core.Abstractions;

namespace MineLink.SignalR;

public class RecordHub : Hub, IMessageService
{
    public async Task SendMessage<T>(string user, T message)
    {
        await Clients.All.SendAsync("ReceiveMessage", user, message);
    }
}