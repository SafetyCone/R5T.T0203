using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0203
{
    /// <inheritdoc cref="IXml"/>
    [StrongTypeImplementationMarker]
    public class Xml : TypedBase<string>, IStrongTypeMarker,
        IXml
    {
        public Xml(string value)
            : base(value)
        {
        }
    }
}