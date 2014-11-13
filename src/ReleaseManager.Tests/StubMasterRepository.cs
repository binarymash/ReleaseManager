﻿using ReleaseManager.Tests.Subversion;
using ReleaseManager.Tests.Jira;

namespace ReleaseManager.Tests
{
    using NHibernate;
    using VersionControl.Svn;

    public static class MasterRepositoryFactory
    {
        public static MasterRepository CreateStubRepo()
        { 
            var repo = new MasterRepository(
                SQLiteDatabase.CreateInMemoryRepository(),
                new SvnRepository(new StubSvnClient()),
                InMemoryIssueRepository.CreateIssueRepository());

            return repo;
        }
    }
}
