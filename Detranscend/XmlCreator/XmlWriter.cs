using System.Xml;

namespace Detranscend.XmlCreator
{
    public class XmlWriter
    {
        public static string WriteDocument(XmlDocument document) => document.OuterXml;
    }
}
