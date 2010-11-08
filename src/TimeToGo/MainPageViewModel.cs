namespace TimeToGo
{
    using Services;

    public class MainPageViewModel : ViewModel, IHandle<CountDownToInstantMessage>
    {
        private int _selectedPivotPageIndex;

        public MainPageViewModel(EventAggregator eventAggregator, CountDownViewModel countDownViewModel, InstantListViewModel instantListViewModel)
        {
            eventAggregator.Subscribe(this);
            CurrentCountDown = countDownViewModel;
            InstantList = instantListViewModel;
        }

        public CountDownViewModel CurrentCountDown { get; private set; }
        public InstantListViewModel InstantList { get; private set; }
        public int SelectedPivotPageIndex
        {
            get { return _selectedPivotPageIndex; }
            set
            {
                if (_selectedPivotPageIndex != value)
                {
                    _selectedPivotPageIndex = value;
                    OnPropertyChanged(() => SelectedPivotPageIndex);
                }
            }
        }

        void IHandle<CountDownToInstantMessage>.Handle(CountDownToInstantMessage message)
        {
            CurrentCountDown.Instant = message.Instant;
            SelectedPivotPageIndex = 0;
        }
    }
}