namespace TimeToGo
{
    using System;

    public class Instant
    {
        public static readonly Instant Default = new Instant(DateTime.Now, "Default");

        public Instant()
        {
            
        }

        public Instant(DateTime time, string description)
        {
            Time = time;
            Description = description;
        }

        public DateTime Time { get; private set; }
        public string Description { get; private set; }
    }
}