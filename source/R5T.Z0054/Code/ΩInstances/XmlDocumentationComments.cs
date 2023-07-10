using System;


namespace R5T.Z0054
{
    public class XmlDocumentationComments : IXmlDocumentationComments
    {
        #region Infrastructure

        public static IXmlDocumentationComments Instance { get; } = new XmlDocumentationComments();


        private XmlDocumentationComments()
        {
        }

        #endregion
    }
}
