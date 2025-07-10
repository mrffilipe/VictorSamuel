using VictorSamuel.Application.Services.Payment.Dtos;

namespace VictorSamuel.Application.Services.Payment
{
    public interface IPaymentService
    {
        Task AddAsync(RegisterPaymentDto dto);
        Task UpdateAsync(UpdatePaymentDto dto);
        Task<Domain.Entities.Payment> GetByIdAsync(Guid id);
        Task<IEnumerable<Domain.Entities.Payment>> GetAllAsync();
    }
}
