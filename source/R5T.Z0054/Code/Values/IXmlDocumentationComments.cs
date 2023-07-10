using System;

using R5T.T0131;
using R5T.T0211;
using R5T.T0211.Extensions;


namespace R5T.Z0054
{
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
    }
}
