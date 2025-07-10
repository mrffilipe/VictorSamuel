using VictorSamuel.Application.Services.DayBlock.Dto;

namespace VictorSamuel.Application.Services.DayBlock
{
    public interface IDayBlockService
    {
        Task AddAsync(RegisterDayBlockDto dto);
        Task DeleteAsync(Guid id);
        Task<Domain.Entities.DayBlock> GetByDateAsync(DateOnly date);
        Task<IEnumerable<Domain.Entities.DayBlock>> GetAllAsync();
    }
}
