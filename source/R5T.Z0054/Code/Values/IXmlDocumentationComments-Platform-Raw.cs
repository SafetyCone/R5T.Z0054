using System;

using R5T.T0131;
using R5T.T0185.Extensions;

namespace R5T.Z0054.Platform.Raw
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
        /// <summary>
        /// Contains both &lt;summary&gt; and &lt;result&gt; elements.
        /// </summary>
        public string N_001 =>
@"
<summary>
Strongly-types a XElement as a a &lt;c&gt; tag in an XML documentation comment.
<para>https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/recommended-tags#c</para>
</summary>
<remarks>
This is a remark.
</remarks>
".Trim();

        /// <summary>
        /// Contains an escaped inheritdoc element! (&amp;lt;inheritdoc&amp;gt;)
        /// </summary>
        public string N_002 =>
@"
            <summary>
            Documentation &lt;inheritdoc&gt; element expansion experiment.
            </summary>
        "
// Do not trim since the leading and trailing whitespace is how the text would be encountered in an XML documentation file.
;

        /// <summary>
        /// Contains an &lt;inheritdoc&gt; element.
        /// </summary>
        public string N_003 =>
@"
<summary>
Test Test Test <inheritdoc cref=""P:R5T.S0082.Program.A"" path=""/summary""/>
</summary>
".Trim();

        /// <summary>
        /// Contains the self-referential inheritdoc word ("inheritdoc").
        /// </summary>
        public string N_004 =>
@"
<summary>
The self-referential inheritdoc element is ""inheritdoc"".
</summary>
".Trim();
    }
}
