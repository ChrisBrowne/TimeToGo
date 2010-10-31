namespace TimeToGo
{
    using Microsoft.Phone.Controls;

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
                new TimeListViewModel(
                    new InstantViewModelFactory(eventAggregator)),
                this);
        }
    }
}