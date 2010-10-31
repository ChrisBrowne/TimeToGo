namespace TimeToGo
{
    public interface IHandle<TMessage>
    {
        void Handle(TMessage message);
    }
}