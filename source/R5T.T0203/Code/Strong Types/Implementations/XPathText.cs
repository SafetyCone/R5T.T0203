using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0203
{
    /// <inheritdoc cref="IXPathText"/>
    [StrongTypeImplementationMarker]
    public class XPathText : TypedBase<string>, IStrongTypeMarker,
        IXPathText
    {
        public XPathText(string value)
            : base(value)
        {
        }
    }
}