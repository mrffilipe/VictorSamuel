using VictorSamuel.Domain.Common;

namespace VictorSamuel.Domain.Entities
{
    public class Event : BaseEntity
    {
        public DateTime StartDateTime { get; private set; }
        public DateTime EndDateTime { get; private set; }

        private Event() { }

        public Event(DateTime startDateTime, DateTime endDateTime)
        {
            StartDateTime = startDateTime;
            EndDateTime = endDateTime;
        }
    }
}
