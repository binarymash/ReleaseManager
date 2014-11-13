namespace ReleaseManager.VersionControl.Interfaces
{
    public class SvnInfoEventArgsWrapper
    {
        public SvnInfoEventArgsWrapper(long lastRevision)
        {
            LastChangeRevision = lastRevision;
        }

        public long LastChangeRevision { get; set; }
    }
}
