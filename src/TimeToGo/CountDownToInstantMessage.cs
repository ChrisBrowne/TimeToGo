namespace TimeToGo
{
    public class CountDownToInstantMessage
    {
        public CountDownToInstantMessage(Instant instant)
        {
            Instant = instant;
        }

        public Instant Instant { get; private set; }
    }
}