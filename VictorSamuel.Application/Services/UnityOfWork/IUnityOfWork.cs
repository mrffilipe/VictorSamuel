namespace VictorSamuel.Application.Services.UnityOfWork
{
    public interface IUnityOfWork
    {
        Task SaveChangesAsync();
    }
}
