namespace MakoIoT.Core.Services.Interface
{
    public interface IObjectFactory
    {
        dynamic Create(Type type);
    }
}
