namespace TimeToGo
{
    using System;
    using System.Collections.ObjectModel;
    using Services;

    public class InstantListViewModel
    {
        public InstantListViewModel(InstantViewModelFactory factory)
        {
            Instants = new ObservableCollection<InstantViewModel>
                        {
                            factory.CreateViewModel(new Instant (DateTime.Now.AddMonths(1), "One months time")),
                            factory.CreateViewModel(new Instant (DateTime.Now.AddMonths(2), "Two months time, far away")),
                            factory.CreateViewModel(new Instant (DateTime.Now.AddMonths(3), "Three months time, v.far away")),
                            factory.CreateViewModel(new Instant (DateTime.Now.AddMonths(4), "Four months time, v.v.far away")),
                            factory.CreateViewModel(new Instant (DateTime.Now.AddMonths(5), "Five months time, v.v.v.far away")),
                        };
        }

        public ObservableCollection<InstantViewModel> Instants { get; set; }
    }
}