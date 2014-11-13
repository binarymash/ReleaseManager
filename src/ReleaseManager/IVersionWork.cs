namespace ReleaseManager
{
    using Model.Interfaces;

    public interface IVersionWork: IVersion
    {
        IRevisionCollection Revisions { get; }
        IVersion VersionData();
    }
}