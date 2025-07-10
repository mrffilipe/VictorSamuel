namespace VictorSamuel.Application.Services.User.Dto
{
    public record RegisterUserDto
    {
        public required string FirstName { get; init; }
        public required string LastName { get; init; }
        public required string CpfCnpj { get; init; }
        public required string Phone { get; init; }
        public required DateOnly BirthDate { get; init; }
    }
}
