namespace MineLink.Core.Abstractions;

public interface IMessageService
{
    Task SendMessage<T>(string user, T message);
}