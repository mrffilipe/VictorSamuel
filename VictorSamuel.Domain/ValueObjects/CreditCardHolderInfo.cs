namespace VictorSamuel.Domain.ValueObjects
{
    public record CreditCardHolderInfo
    {
        public string Name { get; init; } = string.Empty;
        public string Email { get; init; } = string.Empty;
        public string CpfCnpj { get; init; } = string.Empty;
        public string PostalCode { get; init; } = string.Empty;
        public string AddressNumber { get; init; } = string.Empty;
        public string? AddressComplement { get; init; }
        public string Phone { get; init; } = string.Empty;
        public string? MobilePhone { get; init; }
    }
}
