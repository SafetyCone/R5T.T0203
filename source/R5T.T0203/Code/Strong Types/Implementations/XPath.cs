using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0203
{
    /// <inheritdoc cref="IXPath"/>
    [StrongTypeImplementationMarker]
    public class XPath : TypedBase<string>, IStrongTypeMarker,
        IXPath
    {
        public XPath(string value)
            : base(value)
        {
        }
    }
}