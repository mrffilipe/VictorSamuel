using VictorSamuel.Domain.Common;
using VictorSamuel.Domain.Enums;

namespace VictorSamuel.Domain.Entities
{
    public class Payment : BaseEntity
    {
        public string AsaasPaymentId { get; private set; } = string.Empty;
        public BillingType BillingType { get; private set; }
        public decimal Value { get; private set; }
        public DateTime DueDate { get; private set; }
        public decimal? TotalValue { get; private set; }
        public int? InstallmentCount { get; private set; }
        public decimal? InstallmentValue { get; private set; }
        public PaymentStatus Status { get; private set; }

        public Guid CustomerId { get; private set; }
        public Customer Customer { get; private set; } = null!;

        public ICollection<Event> Events { get; private set; } = [];

        private Payment() { }

        public Payment(string asaasPaymentId, BillingType billingType, decimal value, DateTime dueDate, Customer customer)
        {
            AsaasPaymentId = asaasPaymentId;
            BillingType = billingType;
            Value = value;
            DueDate = dueDate;
            Status = PaymentStatus.Pending;
            CustomerId = customer.Id;
        }

        public Payment(
            string asaasPaymentId,
            BillingType billingType,
            decimal value,
            DateTime dueDate,
            Customer customer,
            decimal totalValue,
            int installmentCount,
            decimal installmentValue) : this(asaasPaymentId, billingType, value, dueDate, customer)
        {
            TotalValue = totalValue;
            InstallmentCount = installmentCount;
            InstallmentValue = installmentValue;
        }
    }
}
