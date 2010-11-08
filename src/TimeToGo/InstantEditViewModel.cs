namespace TimeToGo
{
    public class InstantEditViewModel
    {
        public InstantEditViewModel(Instant instant)
        {
            Instant = instant;
        }

        public Instant Instant { get; private set; }
    }
}