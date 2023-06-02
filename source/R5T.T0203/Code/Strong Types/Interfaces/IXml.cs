using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0203
{
    /// <summary>
    /// <inheritdoc cref="IXmlText" path="/summary"/>
    /// (Quality-of-life name for <see cref="IXmlText"/>.)
    /// </summary>
    [StrongTypeMarker]
    public interface IXml : IStrongTypeMarker,
        IXmlText
    {
    }
}