namespace ReleaseManager.Tracking.Jira
{
    public interface IStatusMap
    {
        bool this[string status] { get; }
    }
}