namespace VictorSamuel.Application.Services.Payment.Dtos
{
    public record UpdatePaymentDto : RegisterPaymentDto
    {
        public required Guid Id { get; init; }
    }
}
