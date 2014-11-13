namespace ReleaseManager.Data.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Model.Interfaces;

    public interface IEntityRepository
    {
        IQueryable<IRelease> GetReleases();
        IRelease GetRelease(string releaseName);
        IRelease CreateRelease(string name);
        IRelease CreateRelease(string name, string releaseManager, DateTime? releaseDate);
        void SaveRelease(IRelease release);
        void DeleteRelease(IRelease release);

        IQueryable<IComponent> GetComponents();
        IComponent GetComponent(string componentName);
        IComponent CreateComponent(string name, string location);
        void SaveComponent(IComponent component);
        void DeleteComponent(IComponent component);

        IVersion GetVersion(string releaseName, string componentName);
        IQueryable<IVersion> GetVersionsInRelease(string releaseName);
        IQueryable<IVersion> GetVersionsOfComponent(string componentName);
        IVersion CreateVersion(string releaseName, string componentName, long startRevision, long? endRevision);
        void SaveVersion(IVersion version);
        void DeleteVersion(IVersion version);

    }
}

