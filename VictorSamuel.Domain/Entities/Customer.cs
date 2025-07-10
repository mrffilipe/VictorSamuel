using VictorSamuel.Domain.Common;

namespace VictorSamuel.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string AsaasCustomerId { get; private set; } = string.Empty;

        public Guid UserId { get; private set; }
        public User User { get; private set; } = null!;

        public ICollection<Payment> Payments { get; private set; } = [];

        private Customer() { }

        public Customer(string asaasCustomerId)
        {
            AsaasCustomerId = asaasCustomerId;
        }
    }
}
