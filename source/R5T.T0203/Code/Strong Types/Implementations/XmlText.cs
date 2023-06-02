using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0203
{
    /// <inheritdoc cref="IXmlText"/>
    [StrongTypeImplementationMarker]
    public class XmlText : TypedBase<string>, IStrongTypeMarker,
        IXmlText
    {
        public XmlText(string value)
            : base(value)
        {
        }
    }
}