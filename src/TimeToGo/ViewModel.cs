namespace TimeToGo
{
    using System;
    using System.ComponentModel;
    using System.Linq.Expressions;
    using System.Windows;

    public abstract class ViewModel<TViewModel> : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                Action action = () => handler(this, new PropertyChangedEventArgs(propertyName));
                if (Deployment.Current.Dispatcher.CheckAccess())
                {
                    action();
                }
                else
                {
                    Deployment.Current.Dispatcher.BeginInvoke(action);
                }
            }
        }

        protected void OnPropertyChanged<TReturn>(Expression<Func<TViewModel, TReturn>> expr)
        {
            string propertyName = ((MemberExpression) expr.Body).Member.Name;
            OnPropertyChanged(propertyName);
        }
    }
}