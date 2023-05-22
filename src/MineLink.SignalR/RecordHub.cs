using Microsoft.AspNetCore.SignalR;
using MineLink.Core.Abstractions;

namespace MineLink.SignalR
{
    public class RecordHub : Hub, IMessageService
    {
        public void SendMessage<T>(T message)
        {
            throw new NotImplementedException();
        }
    }
}