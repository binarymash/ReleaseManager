namespace ReleaseManager.VersionControl.Interfaces
{
    using System.Collections.Generic;
    using Model.Interfaces;

    public interface IVersionControlRepository
    {
        IEnumerable<ILogItem> GetLogItems(string target, long startRevision, long? endRevision);
        long GetLastChangeRevision(string target);
    }
}