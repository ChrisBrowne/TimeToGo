namespace TimeToGo.Services
{
    using System;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Navigation;

    public class TimeToGoNavigationService : ITimeToGoNavigationService
    {
        private NavigationService _navigationService;
        private Instant _instant;

        private NavigationService NavigationService
        {
            get
            {
                if (_navigationService == null)
                {
                    var app = (Application.Current as App);
                    var page = (app.RootFrame.Content as Page);
                    _navigationService = page.NavigationService;
                    _navigationService.Navigated += NavigationServiceNavigated;
                }
                return _navigationService;
            }
        }

        private void NavigationServiceNavigated(object sender, NavigationEventArgs e)
        {
            var view = e.Content as InstantEditView;
            if (view != null)
            {
                InstantEditViewModel viewModel = new InstantEditViewModel(_instant);
                view.DataContext = viewModel;
            }
        }

        public void NavigateTo(Uri source)
        {
            NavigationService.Navigate(source);
        }

        public void EditInstant(Instant instant)
        {
            _instant = instant;
            NavigationService.Navigate(new Uri("/InstantEditView.xaml", UriKind.Relative));
        }
    }
}