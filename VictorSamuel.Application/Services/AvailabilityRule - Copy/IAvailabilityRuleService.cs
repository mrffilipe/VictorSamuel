using VictorSamuel.Application.Services.AvailabilityRule.Dtos;

namespace VictorSamuel.Application.Services.AvailabilityRule
{
    public interface IAvailabilityRuleService
    {
        Task AddAsync(RegisterAvailabilityRuleDto dto);
        Task UpdateAsync(UpdateAvailabilityRuleDto dto);
        Task DeleteAsync(Guid id);
        Task<Domain.Entities.AvailabilityRule> GetByIdAsync(Guid id);
        Task<IEnumerable<Domain.Entities.AvailabilityRule>> GetAllAsync();
    }
}
