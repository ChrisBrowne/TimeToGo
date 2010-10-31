namespace TimeToGo
{
    using System;

    public class InstantViewModel
    {
        private readonly Instant _instant;

        public InstantViewModel(Instant instant)
        {
            _instant = instant;
        }

        public DateTime Time { get { return _instant.Time; } }
        public string Description { get { return _instant.Description; } }

        public void StartCountDown()
        {
            // raise an event onthe event hub to start counting down to this command...
        }
    }
}