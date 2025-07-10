using VictorSamuel.Domain.Common;

namespace VictorSamuel.Domain.Entities
{
    public class UserExternalLogin : BaseEntity
    {
        public string ProviderIssuer { get; private set; } = string.Empty;
        public string ProviderSubject { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;
        public DateTime LinkedAt { get; private set; }
        public DateTime LastSyncedAt { get; private set; }

        public Guid UserId { get; private set; }
        public User User { get; private set; } = null!;

        private UserExternalLogin() { }

        public UserExternalLogin(string providerIssuer, string providerSubject, string email)
        {
            ProviderIssuer = providerIssuer;
            ProviderSubject = providerSubject;
            Email = email;

            var now = DateTime.UtcNow;
            LinkedAt = now;
            LastSyncedAt = now;
        }

        public UserExternalLogin(string providerIssuer, string providerSubject, string email, User user)
            : this(providerIssuer, providerSubject, email)
        {
            User = user;
        }
    }
}
