namespace MercedesStore.Contract
{
    public interface IRepositoryManager
    {
        IAutoRepository AutoRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        IReviewRepository ReviewRepository { get; }
        Task SaveAsync();
    }
}
