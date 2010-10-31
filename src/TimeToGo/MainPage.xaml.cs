namespace TimeToGo
{
    using Microsoft.Phone.Controls;

    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            DataContext = new MainPageViewModel();
        }
    }
}