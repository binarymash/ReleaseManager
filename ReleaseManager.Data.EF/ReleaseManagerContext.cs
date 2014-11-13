namespace ReleaseManager.Data.EF
{
    using System.Data.Entity;
    using Model;

    public class ReleaseManagerContext : DbContext
    {
        public ReleaseManagerContext() : base("ReleaseManager")
        {
        }

        public DbSet<Version> Versions { get; set; }
        public DbSet<Release> Releases { get; set; }
        public DbSet<Component> Components { get; set; }
    }
}
