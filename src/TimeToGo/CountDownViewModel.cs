namespace TimeToGo
{
    using System;
    using System.Threading;

    public class CountDownViewModel : ViewModel<CountDownViewModel>
    {
        private readonly Instant _instant;

        public CountDownViewModel() : this(Instant.Default)
        {
        }

        public CountDownViewModel(Instant instant)
        {
            _instant = instant;
            _timer = new Timer(TimerTick, null, 0, 1000);
        }

        private string _currentCountDownTime;
        private Timer _timer;

        private void TimerTick(object state)
        {
            CurrentCountDownTime = Math.Floor(_instant.Time.Subtract(DateTime.Now).TotalSeconds) + "\r\nsecs";
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

    }
}