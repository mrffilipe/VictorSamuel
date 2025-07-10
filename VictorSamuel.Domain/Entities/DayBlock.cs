using VictorSamuel.Domain.Common;

namespace VictorSamuel.Domain.Entities
{
    public class DayBlock : BaseEntity
    {
        public DateOnly Date { get; private set; }
        public string? Reason { get; private set; }

        private DayBlock() { }

        public DayBlock(DateOnly date, string? reason)
        {
            Date = date;
            Reason = reason;
        }
    }
}
