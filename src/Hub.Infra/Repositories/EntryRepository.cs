namespace Hub.Infra.Repositories
{
    public class EntryRepository : IEntryRepository
    {
        public async Task<Entry> GetEntriesWaitingForFundsAsync()
        {
            return DB.Load();
        }
    }
}