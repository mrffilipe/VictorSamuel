using VictorSamuel.Domain.Common;

namespace VictorSamuel.Domain.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; private set; } = string.Empty;
        public string LastName { get; private set; } = string.Empty;
        public string CpfCnpj { get; private set; } = string.Empty;
        public string Phone { get; private set; } = string.Empty;
        public DateOnly BirthDate { get; private set; }

        public ICollection<UserExternalLogin> UserExternalLogins { get; private set; } = [];
        public ICollection<Event> Events { get; private set; } = [];

        private User() { }

        public User(
            string firstName,
            string lastName,
            string cpfCnpj,
            string phone,
            DateOnly birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            CpfCnpj = cpfCnpj;
            Phone = phone;
            BirthDate = birthDate;
        }

        public void AddUserExternalLogin(UserExternalLogin externalLogin)
        {
            if (UserExternalLogins.Any(u => u.ProviderIssuer == externalLogin.ProviderIssuer
                                            && u.Email == externalLogin.Email))
                throw new Exception("Já existe um login para esse usuário");

            UserExternalLogins.Add(externalLogin);
        }
    }
}
