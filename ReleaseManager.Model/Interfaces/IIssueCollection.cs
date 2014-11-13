namespace ReleaseManager.Model.Interfaces
{
    using System.Collections.Generic;

    public interface IIssueCollection: IList<IIssue>
    {
        bool CanBeReleased { get; }
    }
}