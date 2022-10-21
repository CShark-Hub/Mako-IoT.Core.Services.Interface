using MakoIoT.Messages;

namespace MakoIoT.Core.Services.Interface
{
    public interface IConsumer<T> where T : IMessage
    {
        void Consume(ConsumeContext<T> context);
    }
}