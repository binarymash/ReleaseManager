﻿namespace ReleaseManager.VersionControl.Svn
{
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class SvnConfigException : Exception
    {
        public SvnConfigException()
        { }

        public SvnConfigException(string message)
            : base(message)
        { }

        public SvnConfigException(string message, Exception innerException)
            : base(message, innerException)
        { }

        protected SvnConfigException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        { }
    }
}