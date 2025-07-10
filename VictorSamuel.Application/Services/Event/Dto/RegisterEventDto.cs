namespace VictorSamuel.Application.Services.Event.Dto
{
    public record RegisterEventDto
    {
        public required DateTime StartDateTime { get; init; }
        public required DateTime EndDateTime { get; init; }
    }
}
