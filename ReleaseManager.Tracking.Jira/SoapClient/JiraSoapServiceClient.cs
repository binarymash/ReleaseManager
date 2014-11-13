using ReleaseManager.Jira;

namespace ReleaseManager.Jira.SoapClient
{
    using Tracking.Jira;

    public partial class JiraSoapServiceClient : IJiraSoapClient
    {
        string IJiraSoapClient.login(string userName, string password)
        {
            return login(userName, password);
        }

        IRemoteStatus[] IJiraSoapClient.getStatuses(string token)
        {
            return getStatuses(token);
        }

        IRemoteIssue IJiraSoapClient.getIssue(string token, string key)
        {
            return getIssue(token, key);
        }
    }
}
