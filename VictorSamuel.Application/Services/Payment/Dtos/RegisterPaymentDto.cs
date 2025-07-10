using VictorSamuel.Domain.Enums;
using VictorSamuel.Domain.ValueObjects;

namespace VictorSamuel.Application.Services.Payment.Dtos
{
    public record RegisterPaymentDto
    {
        public required BillingType BillingType { get; init; }
        public required decimal Value { get; init; }
        public required DateTime DueDate { get; init; }
        public decimal? TotalValue { get; init; }
        public int? InstallmentCount { get; init; }
        public decimal? InstallmentValue { get; init; }
        public CreditCard? CreditCard { get; init; }
        public CreditCardHolderInfo? CreditCardHolderInfo { get; init; }
    }
}
