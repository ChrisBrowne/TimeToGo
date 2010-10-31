namespace TimeToGo
{
    using System;
    using System.Collections.ObjectModel;

    public class TimeListViewModel
    {
        public TimeListViewModel()
        {
            Times = new ObservableCollection<InstantViewModel>
                        {
                            new InstantViewModel(new Instant (DateTime.Now.AddMonths(1), "One months time")),
                            new InstantViewModel(new Instant (DateTime.Now.AddMonths(2), "Two months time, far away")),
                            new InstantViewModel(new Instant (DateTime.Now.AddMonths(3), "Three months time, v.far away")),
                            new InstantViewModel(new Instant (DateTime.Now.AddMonths(4), "Four months time, v.v.far away")),
                            new InstantViewModel(new Instant (DateTime.Now.AddMonths(5), "Five months time, v.v.v.far away")),
                        };
        }

        public ObservableCollection<InstantViewModel> Times { get; set; }
    }
}