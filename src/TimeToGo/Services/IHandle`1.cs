namespace TimeToGo.Services
{
    public interface IHandle<TMessage>
    {
        void Handle(TMessage message);
    }
}