namespace TimeToGo
{
    public class MainPageViewModel : IHandle<CountDownToTimeMessage>
    {
        private readonly MainPage _view;

        public MainPageViewModel(EventAggregator eventAggregator, CountDownViewModel countDownViewModel, TimeListViewModel timeListViewModel, MainPage view)
        {
            _view = view;
            eventAggregator.Subscribe(this);
            CurrentCountDown = countDownViewModel;
            TimeList = timeListViewModel;
        }

        public CountDownViewModel CurrentCountDown { get; private set; }
        public TimeListViewModel TimeList { get; private set; }

        void IHandle<CountDownToTimeMessage>.Handle(CountDownToTimeMessage message)
        {
            CurrentCountDown.Instant = message.Instant;
            _view.MainPivot.SelectedIndex = 0;
        }
    }
}