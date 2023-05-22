namespace MineLink.Core.Abstractions;

public interface IMessageService
{
    void SendMessage<T>(T message);
}