using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0203
{
    /// <summary>
    /// Strongly-types a string as an XPath expression.
    /// </summary>
    [StrongTypeMarker]
    public interface IXPathText : IStrongTypeMarker,
        ITyped<string>
    {
    }
}