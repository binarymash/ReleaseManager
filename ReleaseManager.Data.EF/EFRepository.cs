namespace ReleaseManager.Data.EF
{
    using System;
    using System.Linq;
    using Model;
    using ReleaseManager.Data.Interfaces;
    using ReleaseManager.Model.Interfaces;

    public class EFRepository : IEntityRepository, IDisposable
    {
        private static EFRepository _instance;
        private ReleaseManagerContext _context;


        public IRelease CreateRelease(string name)
        {
            return this.CreateRelease(name, null, null);
        }

        public IRelease CreateRelease(string name, string releaseManager, DateTime? releaseDate)
        {
            return null;
            //using (this.sessionFactory.OpenSession())
            //{
            //    return new Release {
            //        Name = name,
            //        ReleaseManager = releaseManager,
            //        ReleaseDate = releaseDate };
            //}
        }

        public void DeleteRelease(IRelease release)
        {
            //IList<IVersion> versions = this.GetVersionsInRelease(release.Name);

            //using (ISession session = this.sessionFactory.OpenSession())
            //{
            //    ITransaction tran = session.BeginTransaction();
            //    foreach (var version in versions)
            //    {
            //        session.Delete(version);
            //    }
            //    session.Delete(release);
            //    tran.Commit();
            //}
        }
        
        protected virtual void Dispose(bool all)
        {

        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public IComponent GetComponent(string componentName)
        {
            return _context.Components.FirstOrDefault(c => c.Name == componentName);
        }

        public IQueryable<IComponent> GetComponents()
        {
            return _context.Components;
        }
        
        public IRelease GetRelease(string releaseName)
        {
            return _context.Releases.FirstOrDefault(r => r.Name == releaseName);
        }

        public IQueryable<IRelease> GetReleases()
        {
            return _context.Releases;
        }

        public IVersion GetVersion(string releaseName, string componentName)
        {
            return _context.Versions.FirstOrDefault(v => 
                v.Release.Name == releaseName && 
                v.Component.Name == componentName);
        }

        public IQueryable<IVersion> GetVersionsInRelease(string releaseName)
        {
            return _context.Versions.Where(v => v.Release.Name == releaseName).Select(v => v);
        }

        public IQueryable<IVersion> GetVersionsOfComponent(string componentName)
        {
            return _context.Versions.Where(v => v.Component.Name == componentName);
        }

        public void SaveComponent(IComponent component)
        {
            //using (ISession session = this.sessionFactory.OpenSession())
            //{
            //    ITransaction tran = session.BeginTransaction();
            //    session.SaveOrUpdate(component);
            //    tran.Commit();
            //}
        }

        public void SaveRelease(IRelease release)
        {
            //using (ISession session = this.sessionFactory.OpenSession())
            //{
            //    ITransaction tran = session.BeginTransaction();
            //    session.SaveOrUpdate(release);
            //    tran.Commit();
            //}
        }

        public void SaveVersion(IVersion version)
        {
            //using (ISession session = this.sessionFactory.OpenSession())
            //{
            //    ITransaction tran = session.BeginTransaction();
            //    session.SaveOrUpdate(version);
            //    tran.Commit();
            //}
        }

        public static IEntityRepository Instance
        {
            get { return _instance ?? (_instance = new EFRepository()); }
        }

        public void DeleteVersion(IVersion version)
        {
            //using (ISession session = this.sessionFactory.OpenSession())
            //{
            //    ITransaction tran = session.BeginTransaction();
            //    session.Delete(version);
            //    tran.Commit();
            //}
        }

        public void DeleteComponent(IComponent component)
        {
            //IList<IVersion> versions = this.GetVersionsOfComponent(component.Name);

            //using (ISession session = this.sessionFactory.OpenSession())
            //{
            //    ITransaction tran = session.BeginTransaction();
            //    foreach (var version in versions)
            //    {
            //        session.Delete(version);
            //    }
            //    session.Delete(component);
            //    tran.Commit();
            //}
        }

        public IVersion CreateVersion(
            string releaseName,
            string componentName,
            long startRevision,
            long? endRevision)
        {
            return null;
            //Component component = this.GetComponentImpl(componentName);
            //Release release = this.GetReleaseImpl(releaseName);

            //return 
            //    new Version {
            //        Id = 0,
            //        Component = component,
            //        Release = release,
            //        EndRevision = endRevision,
            //        StartRevision = startRevision};
        }

        public IComponent CreateComponent(string name, string location)
        {
            return
                new Component {
                    Name = name,
                    Location = location,
                    Active = true};
        }
 
    }
}