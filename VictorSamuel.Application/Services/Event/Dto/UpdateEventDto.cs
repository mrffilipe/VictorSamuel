namespace VictorSamuel.Application.Services.Event.Dto
{
    public record UpdateEventDto : RegisterEventDto
    {
        public required Guid Id { get; init; }
    }
}
