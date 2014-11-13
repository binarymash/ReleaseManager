namespace ReleaseManager.Model
{
    using System;
    using ReleaseManager.Model.Interfaces;

    public class Release : IRelease
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime? ReleaseDate { get; set; }
        public virtual string ReleaseManager { get; set; }
    }
}

