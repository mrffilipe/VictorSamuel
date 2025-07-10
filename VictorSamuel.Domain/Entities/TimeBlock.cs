using VictorSamuel.Domain.Common;

namespace VictorSamuel.Domain.Entities
{
    public class TimeBlock : BaseEntity
    {
        public DateOnly Date { get; private set; }
        public TimeSpan StartTime { get; private set; }
        public TimeSpan EndTime { get; private set; }
        public string? Reason { get; private set; }

        private TimeBlock() { }

        public TimeBlock(DateOnly date, TimeSpan startTime, TimeSpan endTime, string? reason)
        {
            Date = date;
            StartTime = startTime;
            EndTime = endTime;
            Reason = reason;
        }
    }
}
