namespace Hub.Domain.Repositories
{
    public interface IEntryRepository
    {
        Task<Entry> GetEntriesWaitingForFundsAsync();
    }
}