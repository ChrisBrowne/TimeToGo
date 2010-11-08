namespace TimeToGo.Services
{
    public class InstantViewModelFactory
    {
        private readonly EventAggregator _eventAggregator;
        private readonly TimeToGoNavigationService _timeToGoNavigationService;

        public InstantViewModelFactory(EventAggregator eventAggregator, TimeToGoNavigationService timeToGoNavigationService)
        {
            _eventAggregator = eventAggregator;
            _timeToGoNavigationService = timeToGoNavigationService;
        }

        public InstantViewModel CreateViewModel(Instant instant)
        {
            return new InstantViewModel(instant, _eventAggregator, _timeToGoNavigationService);
        }
    }
}