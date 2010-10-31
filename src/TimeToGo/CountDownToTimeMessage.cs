namespace TimeToGo
{
    public class CountDownToTimeMessage
    {
        public CountDownToTimeMessage(Instant instant)
        {
            Instant = instant;
        }

        public Instant Instant { get; private set; }
    }
}