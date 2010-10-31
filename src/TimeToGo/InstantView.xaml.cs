namespace TimeToGo
{
    using System.Windows;
    using System.Windows.Controls;

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
            MessageBox.Show("Go!");
            ViewModel.StartCountDown();
        }

        private void EditButtonClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Edit!");
        }
    }
}
