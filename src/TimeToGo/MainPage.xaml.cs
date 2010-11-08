namespace TimeToGo
{
    using Microsoft.Phone.Controls;
    using Services;

    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            EventAggregator eventAggregator = new EventAggregator();

            DataContext = new MainPageViewModel(
                eventAggregator,
                new CountDownViewModel(Instant.Default),
                new InstantListViewModel(
                    new InstantViewModelFactory(eventAggregator, new TimeToGoNavigationService())));
        }
    }
}