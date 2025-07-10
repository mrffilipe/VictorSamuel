using VictorSamuel.Application.Services.Event.Dto;

namespace VictorSamuel.Application.Services.Event
{
    public interface EventService
    {
        Task AddAsync(RegisterEventDto dto);
        Task UpdateAsync(UpdateEventDto dto);
        Task DeleteAsync(Guid id);
        Task<IEnumerable<Domain.Entities.Event>> GetByIdAsync(Guid id);
        Task<IEnumerable<Domain.Entities.Event>> GetAllByDateAsync(DateOnly date);
        Task<IEnumerable<Domain.Entities.Event>> GetUpcomingAsync();
        Task<bool> IsAvailableAsync();
    }
}
