namespace TimeToGo
{
    using System;
    using Services;

    public class InstantViewModel
    {
        private readonly Instant _instant;
        private readonly EventAggregator _eventAggregator;
        private readonly ITimeToGoNavigationService _timeToGoNavigationService;

        public InstantViewModel(Instant instant, EventAggregator eventAggregator, ITimeToGoNavigationService timeToGoNavigationService)
        {
            _instant = instant;
            _timeToGoNavigationService = timeToGoNavigationService;
            _eventAggregator = eventAggregator;
        }

        public DateTime Time { get { return _instant.Time; } }
        public string Description { get { return _instant.Description; } }

        public void Select()
        {
            _eventAggregator.Publish(new CountDownToInstantMessage(_instant));
        }

        public void Edit()
        {
            _timeToGoNavigationService.EditInstant(_instant);
        }

        public void Delete()
        {
            
        }
    }
}