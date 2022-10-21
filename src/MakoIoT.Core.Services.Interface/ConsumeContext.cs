using MakoIoT.Messages;

namespace MakoIoT.Core.Services.Interface
{
    public class ConsumeContext<T> where T : IMessage
    {
        public ConsumeContext (Envelope envelope)
        {
            Message = (T)envelope.Message;
            MessageId = envelope.MessageId;
            OriginTime = envelope.OriginTime;
            Sender = envelope.Sender;
            SenderAddress = envelope.SenderAddress;
            ReceivedTime = DateTime.UtcNow;
        }

        public string SenderAddress { get; }

        public string Sender { get; }

        public DateTime OriginTime { get; }

        public string MessageId { get; }

        public T Message { get; }

        public DateTime ReceivedTime { get; }
    }
}
