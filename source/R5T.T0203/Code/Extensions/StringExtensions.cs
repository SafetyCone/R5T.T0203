using System;


namespace R5T.T0203.Extensions
{
    public static class StringExtensions
    {
        /// <inheritdoc cref="IStringOperator.ToXml(string)"/>
        public static IXml ToXml(this string value)
        {
            return Instances.StringOperator_Extensions.ToXml(value);
        }

        /// <inheritdoc cref="IStringOperator.ToXmlText(string)"/>
        public static IXmlText ToXmlText(this string value)
        {
            return Instances.StringOperator_Extensions.ToXmlText(value);
        }

        /// <inheritdoc cref="IStringOperator.ToXPath(String)"/>
        public static IXPath ToXPath(this String value)
        {
            return Instances.StringOperator_Extensions.ToXPath(value);
        }

        /// <inheritdoc cref="IStringOperator.ToXPathText(String)"/>
        public static IXPathText ToXPathText(this String value)
        {
            return Instances.StringOperator_Extensions.ToXPathText(value);
        }
    }
}
