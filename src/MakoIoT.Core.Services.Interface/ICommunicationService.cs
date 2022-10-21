namespace MakoIoT.Core.Services.Interface
{
    public interface ICommunicationService
    {
        void Publish(string messageString, string messageType);
        event EventHandler<string> MessageReceived;
        bool CanSend { get; }
        string ClientName { get; }
        string ClientAddress { get; }
        void Connect(string[] subscriptions);
        void Disconnect();
        void Send(string envelopeString, string recipient);
    }
}
