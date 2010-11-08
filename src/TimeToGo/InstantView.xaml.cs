namespace TimeToGo
{
    using System;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Navigation;

    public partial class InstantView : UserControl
    {
        public InstantView()
        {
            InitializeComponent();
        }

        private InstantViewModel ViewModel
        {
            get { return DataContext as InstantViewModel; }
        }

        private void GoButtonClick(object sender, RoutedEventArgs e)
        {
            ViewModel.Select();
        }

        private void EditButtonClick(object sender, RoutedEventArgs e)
        {
            ViewModel.Edit();
        }

        private void DeleteButtonClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Delete!");
        }
    }
}
