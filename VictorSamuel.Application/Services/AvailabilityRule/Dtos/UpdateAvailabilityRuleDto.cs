namespace VictorSamuel.Application.Services.AvailabilityRule.Dtos
{
    public record UpdateAvailabilityRuleDto : RegisterAvailabilityRuleDto
    {
        public required Guid Id { get; init; }
    }
}
