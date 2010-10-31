namespace TimeToGo
{
    using System;
    using System.Collections.ObjectModel;

    public class InstantViewModelFactory
    {
        private readonly EventAggregator _eventAggregator;

        public InstantViewModelFactory(EventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
        }

        public InstantViewModel CreateViewModel(Instant instant)
        {
            return new InstantViewModel(instant, _eventAggregator);
        }
    }

    public class TimeListViewModel
    {
        public TimeListViewModel(InstantViewModelFactory factory)
        {
            Times = new ObservableCollection<InstantViewModel>
                        {
                            factory.CreateViewModel(new Instant (DateTime.Now.AddMonths(1), "One months time")),
                            factory.CreateViewModel(new Instant (DateTime.Now.AddMonths(2), "Two months time, far away")),
                            factory.CreateViewModel(new Instant (DateTime.Now.AddMonths(3), "Three months time, v.far away")),
                            factory.CreateViewModel(new Instant (DateTime.Now.AddMonths(4), "Four months time, v.v.far away")),
                            factory.CreateViewModel(new Instant (DateTime.Now.AddMonths(5), "Five months time, v.v.v.far away")),
                        };
        }

        public ObservableCollection<InstantViewModel> Times { get; set; }
    }
}