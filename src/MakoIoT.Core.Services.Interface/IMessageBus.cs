using MakoIoT.Messages;

namespace MakoIoT.Core.Services.Interface
{
    public interface IMessageBus
    {
        void Start();
        void Stop();
        void RegisterDirectMessageConsumer(Type messageType, Type consumerType);
        void RegisterSubscriptionConsumer(Type messageType, Type consumerType);
        void Publish(IMessage message, bool delay = false);
        void Send(IMessage message, string recipient);
    }
}