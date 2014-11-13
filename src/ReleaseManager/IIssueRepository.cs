namespace ReleaseManager
{
    using Model.Interfaces;

    public interface IIssueRepository
    {
        IIssue GetIssue(string key);
    }
}

