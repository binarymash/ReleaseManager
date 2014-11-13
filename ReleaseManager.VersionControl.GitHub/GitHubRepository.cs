using System;

namespace ReleaseManager.VersionControl.GitHub
{
    using System.Collections.Generic;
    using Interfaces;
    using Model.Interfaces;

    public class GitHubRepository : IVersionControlRepository, IDisposable
    {
        public IEnumerable<ILogItem> GetLogItems(string target, long startRevision, long? endRevision)
        {
            throw new NotImplementedException();
        }

        public long GetLastChangeRevision(string target)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
