namespace ReleaseManager.Tracking.Jira
{
    public interface IJiraSoapClient
    {
        string login(string userName, string password);
        IRemoteStatus[] getStatuses(string token);
        IRemoteIssue getIssue(string token, string key);
        void Close();
    }
}
