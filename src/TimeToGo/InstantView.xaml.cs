namespace TimeToGo
{
    using System;
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
            ViewModel.StartCountDown();
        }

        private void EditButtonClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Edit!");
        }

        private void DeleteButtonClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Delete!");
        }
    }
}
