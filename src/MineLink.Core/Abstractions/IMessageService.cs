namespace MineLink.Core.Abstractions;

public interface IMessageService
{
    void Send<T>(T message);
}