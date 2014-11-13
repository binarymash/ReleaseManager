namespace ReleaseManager.VersionControl.Svn
{
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class SvnGetLogException : Exception
    {
        public SvnGetLogException()
        {}

        public SvnGetLogException(string message) : base(message)
        {}

        public SvnGetLogException(string message, Exception innerException) : base(message, innerException)
        {}

        protected SvnGetLogException(SerializationInfo info, StreamingContext context): base(info, context)
        {}
    }
}

