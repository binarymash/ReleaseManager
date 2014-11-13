namespace ReleaseManager.VersionControl.Interfaces
{
    public interface ISvnConfig
    {
        string UserName { get; }
        string Password { get; }
    }
}