namespace TimeToGo
{
    using System;

    public class InstantViewModel
    {
        private readonly Instant _instant;
        private readonly EventAggregator _eventAggregator;

        public InstantViewModel(Instant instant, EventAggregator eventAggregator)
        {
            _instant = instant;
            _eventAggregator = eventAggregator;
        }

        public DateTime Time { get { return _instant.Time; } }
        public string Description { get { return _instant.Description; } }

        public void StartCountDown()
        {
            _eventAggregator.Publish(new CountDownToTimeMessage(_instant));
        }
    }
}