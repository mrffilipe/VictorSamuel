using VictorSamuel.Application.Services.User.Dto;

namespace VictorSamuel.Application.Services.User
{
    public interface IUserService
    {
        Task AddAsync(RegisterUserDto dto);
        Task UpdateAsync(UpdateUserDto dto);
        Task DeleteAsync(Guid id);
        Task<IEnumerable<Domain.Entities.User>> GetByIdAsync(Guid id);
        Task<IEnumerable<Domain.Entities.User>> GetAllAsync();
        Task<bool> AlreadyExists();
    }
}
