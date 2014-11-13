namespace ReleaseManager.Tracking.Jira
{
    public interface IRemoteIssue
    {
        string assignee { get; }
        string key { get; }
        string summary { get; }
        string status { get; }
    }
}
