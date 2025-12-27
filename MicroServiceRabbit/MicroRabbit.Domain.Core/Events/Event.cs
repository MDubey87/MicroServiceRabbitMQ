namespace MicroRabbit.Domain.Core.Events
{
    public abstract class Event
    {
        public DateTime Timestamp { get; private set; }
        protected Event()
        {
            Timestamp = DateTime.UtcNow;
        }
    }
}
