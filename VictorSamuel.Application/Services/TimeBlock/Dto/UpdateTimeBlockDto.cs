namespace VictorSamuel.Application.Services.TimeBlock.Dto
{
    public record UpdateTimeBlockDto : RegisterTimeBlockDto
    {
        public required Guid Id { get; init; }
    }
}
