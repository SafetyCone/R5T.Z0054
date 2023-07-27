using System;

using R5T.T0131;
using R5T.T0211;
using R5T.T0211.Extensions;


namespace R5T.Z0054
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
        public IXmlDocumentationComment SummaryAndResult =>
@"
<summary>
Strongly-types a XElement as a a &lt;c&gt; tag in an XML documentation comment.
<para>https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/recommended-tags#c</para>
</summary>
<remarks>
This is a remark.
</remarks>
".Trim().ToXmlDocumentationComment();

        public IXmlDocumentationComment WithDocumentationFileFormatting =>
@"
            <summary>
            Documentation &lt;inheritdoc&gt; element expansion experiment.
            </summary>
        "
// Do not trim.
.ToXmlDocumentationComment();

    }
}
