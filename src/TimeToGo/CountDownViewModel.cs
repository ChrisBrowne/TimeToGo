namespace TimeToGo
{
    using System;
    using System.Threading;

    public class CountDownViewModel : ViewModel<CountDownViewModel>
    {
        private Instant _instant;
        private string _currentCountDownTime;
        private Timer _timer;

        public CountDownViewModel(Instant instant)
        {
            Instant = instant;
            _timer = new Timer(TimerTick, null, 0, 1000);
        }

        private void TimerTick(object state)
        {
            UpdateTime();
        }

        private void UpdateTime()
        {
            CurrentCountDownTime = Math.Floor(Instant.Time.Subtract(DateTime.Now).TotalSeconds) + "\r\nsecs";
        }

        public string CurrentCountDownTime
        {
            get { return _currentCountDownTime; }
            set
            {
                if (_currentCountDownTime != value)
                {
                    _currentCountDownTime = value;
                    OnPropertyChanged(x => x.CurrentCountDownTime);
                }
            }
        }

        public string Description
        {
            get { return Instant.Description; }
        }

        public Instant Instant
        {
            private get { return _instant; }
            set
            {
                _instant = value;
                UpdateTime();
                OnPropertyChanged(x => x.Description);
            }
        }
    }
}