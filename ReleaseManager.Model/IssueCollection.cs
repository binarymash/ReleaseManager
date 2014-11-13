namespace ReleaseManager.Model
{
    using System.Collections.Generic;
    using System.Linq;
    using Interfaces;

    public class IssueCollection : List<IIssue>, IIssueCollection
    {
        public IssueCollection(IEnumerable<IIssue> issues) : base(issues)
        {}

        public bool CanBeReleased
        {
            get
            {
                if (Count == 0)
                {
                    return false;
                }
                return this.Select(i => i.CanBeReleased).Aggregate((a,b)=> a && b);
            }
        }
    }
}