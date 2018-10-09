namespace Library.Common.Contracts
{
    public interface IBaseItem
    {
        string Title { get; }
        string Isbn { get; }
        void DownloadItem();
    }
}
