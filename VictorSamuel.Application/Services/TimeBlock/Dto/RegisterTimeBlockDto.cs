namespace VictorSamuel.Application.Services.TimeBlock.Dto
{
    public record RegisterTimeBlockDto
    {
        public required DateOnly Date { get; init; }
        public required TimeSpan StartTime { get; init; }
        public required TimeSpan EndTime { get; init; }
        public string? Reason { get; init; }
    }
}
