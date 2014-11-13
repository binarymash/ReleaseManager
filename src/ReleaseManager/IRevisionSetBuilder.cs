namespace ReleaseManager
{
    using Model.Interfaces;

    public interface IRevisionSetBuilder
    {
        IRevisionCollection CreateRevisionSet(IVersion version);
    }
}

