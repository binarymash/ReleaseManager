namespace ReleaseManager.Tracking.Jira
{
    using System;

    public interface IJiraConfig
    {
        string UserName { get; }
        string Password { get; }
        TimeSpan CacheExpireTime { get; }
        Uri BaseUri { get; }
        IStatusMap StatusMap { get; }
    }
}