using VictorSamuel.Domain.Common;

namespace VictorSamuel.Domain.Entities
{
    public class AvailabilityRule : BaseEntity
    {
        public DayOfWeek DayOfWeek { get; private set; }
        public TimeSpan StartTime { get; private set; }
        public TimeSpan? EndTime { get; private set; }
        public bool AllowUnlimitedEvent { get; private set; }

        private AvailabilityRule() { }

        public AvailabilityRule(DayOfWeek dayOfWeek, TimeSpan startTime, TimeSpan? endTime, bool allowUnlimitedEvent)
        {
            DayOfWeek = dayOfWeek;
            StartTime = startTime;
            EndTime = endTime;
            AllowUnlimitedEvent = allowUnlimitedEvent;
        }
    }
}
