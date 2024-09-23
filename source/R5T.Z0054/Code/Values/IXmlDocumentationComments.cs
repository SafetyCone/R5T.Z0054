using System;

using R5T.T0131;
using R5T.T0143;
using R5T.T0211;
using R5T.T0211.Extensions;


namespace R5T.Z0054
{
    /// <inheritdoc cref="Platform.IXmlDocumentationComments"/>
    [ValuesMarker]
    public partial interface IXmlDocumentationComments : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Platform.IXmlDocumentationComments _Platform => Platform.XmlDocumentationComments.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Platform.IXmlDocumentationComments.Contains_InheritdocElement"/>
        public IXmlDocumentationComment Contains_InheritdocElement => _Platform.Contains_InheritdocElement.ToXmlDocumentationComment();

        /// <inheritdoc cref="Platform.IXmlDocumentationComments.Pathological_ContainsEscapedInheritdoc"/>
        public IXmlDocumentationComment Pathological_ContainsEscapedInheritdoc => _Platform.Pathological_ContainsEscapedInheritdoc.ToXmlDocumentationComment();

        /// <inheritdoc cref="Platform.IXmlDocumentationComments.Pathological_ContainsSelfReferentialInheritdoc"/>
        public IXmlDocumentationComment Pathological_ContainsSelfReferentialInheritdoc => _Platform.Pathological_ContainsSelfReferentialInheritdoc.ToXmlDocumentationComment();

        /// <inheritdoc cref="Platform.IXmlDocumentationComments.SummaryAndResult"/>
        public IXmlDocumentationComment SummaryAndResult => _Platform.SummaryAndResult.ToXmlDocumentationComment();

        /// <inheritdoc cref="Platform.IXmlDocumentationComments.WithDocumentationFileFormatting"/>
        public IXmlDocumentationComment WithDocumentationFileFormatting => _Platform.WithDocumentationFileFormatting.ToXmlDocumentationComment();
    }
}
