using VictorSamuel.Domain.Common;
using VictorSamuel.Domain.Enums;

namespace VictorSamuel.Domain.Entities
{
    public class Event : BaseEntity
    {
        public DateTime StartDateTime { get; private set; }
        public DateTime EndDateTime { get; private set; }
        public EventStatus Status { get; private set; }

        public Guid UserId { get; private set; }
        public User User { get; private set; } = null!;
        public Guid PaymentId { get; private set; }
        public Payment Payment { get; private set; } = null!;

        private Event() { }

        public Event(DateTime startDateTime, DateTime endDateTime, User user)
        {
            StartDateTime = startDateTime;
            EndDateTime = endDateTime;
            User = user;
        }

        public void SetPayment(Payment payment)
        {
            if (payment == null)
                throw new Exception("Pagamento não pode ser nulo");

            Payment = payment;
        }
    }
}
