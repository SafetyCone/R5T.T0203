using System;

using R5T.T0132;


namespace R5T.T0203.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="IXml"/>
        public IXml ToXml(string value)
        {
            var output = new Xml(value);
            return output;
        }

        /// <inheritdoc cref="IXmlText"/>
        public IXmlText ToXmlText(string value)
        {
            var output = new XmlText(value);
            return output;
        }
    }
}
