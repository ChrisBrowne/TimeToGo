namespace TimeToGo.Services
{
    using System.Collections.Generic;
    using System.Linq;

    public class EventAggregator
    {
        private readonly List<object> _listeners= new List<object>();

        public void Subscribe(object listener)
        {
            if (!_listeners.Contains(listener))
            {
                _listeners.Add(listener);
            }
        }

        public void Publish<TMessage>(TMessage message)
        {
            foreach (var handle in _listeners.OfType<IHandle<TMessage>>())
            {
                handle.Handle(message);
            }
        }
    }
}