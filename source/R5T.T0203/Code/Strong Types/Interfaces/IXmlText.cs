using System;

using R5T.T0178;
using R5T.T0185;


namespace R5T.T0203
{
    /// <summary>
    /// Strongly-types a string as XML text.
    /// </summary>
    [StrongTypeMarker]
    public interface IXmlText : IStrongTypeMarker,
        IText
    {
    }
}