namespace SuggestionAppLibrary.DataAccess
{
    internal interface IStatusData
    {
        Task CreateStatuses(StatusModel status);
        Task<List<StatusModel>> GetAllStatuses();
    }
}