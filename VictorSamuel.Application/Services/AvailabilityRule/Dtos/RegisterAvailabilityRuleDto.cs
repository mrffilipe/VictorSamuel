namespace VictorSamuel.Application.Services.AvailabilityRule.Dtos
{
    public record RegisterAvailabilityRuleDto
    {
        public required DayOfWeek DayOfWeek { get; init; }
        public required TimeSpan StartTime { get; init; }
        public TimeSpan? EndTime { get; init; }
        public required bool AllowUnlimitedEvent { get; init; }
    }
}
