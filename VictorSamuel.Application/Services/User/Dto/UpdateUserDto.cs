namespace VictorSamuel.Application.Services.User.Dto
{
    public record UpdateUserDto : RegisterUserDto
    {
        public required Guid Id { get; init; }
    }
}
