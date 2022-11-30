namespace dev_events_service.Interface
{
    public interface ICepService
    {
        Task<object> GetCepAsync(string cep);
    }
}
