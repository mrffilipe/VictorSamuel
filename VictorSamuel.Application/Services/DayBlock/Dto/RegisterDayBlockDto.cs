namespace VictorSamuel.Application.Services.DayBlock.Dto
{
    public record RegisterDayBlockDto
    {
        public required DateOnly Date { get; init; }
        public string? Reason { get; init; }
    }
}
