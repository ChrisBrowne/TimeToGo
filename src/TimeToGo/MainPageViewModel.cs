namespace TimeToGo
{
    using System;

    public class MainPageViewModel
    {
        public MainPageViewModel()
        {
            CurrentCountDown = new CountDownViewModel(Instant.Default);
            TimeList = new TimeListViewModel();
        }

        public CountDownViewModel CurrentCountDown { get; private set; }
        public TimeListViewModel TimeList { get; private set; }
    }
}