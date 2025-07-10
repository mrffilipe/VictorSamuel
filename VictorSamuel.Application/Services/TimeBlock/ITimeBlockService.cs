using VictorSamuel.Application.Services.TimeBlock.Dto;

namespace VictorSamuel.Application.Services.TimeBlock
{
    public interface ITimeBlockService
    {
        Task AddAsync(RegisterTimeBlockDto dto);
        Task UpdateAsync(UpdateTimeBlockDto dto);
        Task DeleteAsync(Guid id);
        Task<IEnumerable<Domain.Entities.TimeBlock>> GetByDateAsync(DateOnly date);
        Task<IEnumerable<Domain.Entities.TimeBlock>> GetAllAsync();
    }
}
