using System;

using R5T.T0131;
using R5T.T0143;


namespace R5T.Z0054.Platform
{
    /// <summary>
    /// The XML documentation comments themselves.
    /// <para>
    /// Note: these values are less useful, because they frequently contain multiple root (for example, a "summary" and "remarks").
    /// This prevents them from being easily parsed to an XElement (because there are multiple roots) or an XDocument.
    /// More useful are the R5T.Z0055 member XML texts, like MemberElementXmlTexts, since they are a single root element and so can be directly parsed.
    /// </para>
    /// </summary>
    [ValuesMarker]
    public partial interface IXmlDocumentationComments : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Raw.IXmlDocumentationComments _Raw => Raw.XmlDocumentationComments.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Raw.IXmlDocumentationComments.N_003"/>
        public string Contains_InheritdocElement => _Raw.N_003;

        /// <inheritdoc cref="Raw.IXmlDocumentationComments.N_002"/>
        public string Pathological_ContainsEscapedInheritdoc => _Raw.N_002;

        /// <inheritdoc cref="Raw.IXmlDocumentationComments.N_004"/>
        public string Pathological_ContainsSelfReferentialInheritdoc => _Raw.N_004;

        /// <inheritdoc cref="Raw.IXmlDocumentationComments.N_002"/>
        public string SummaryAndResult => _Raw.N_001;

        /// <summary>
        /// Contains the leading, trailing, and internal whitespace formatting that would be encountered in an XML documentation file.
        /// Note: also contains an escaped inheritdoc element! (&amp;lt;inheritdoc&amp;gt;)
        /// </summary>
        public string WithDocumentationFileFormatting => _Raw.N_002;

    }
}
