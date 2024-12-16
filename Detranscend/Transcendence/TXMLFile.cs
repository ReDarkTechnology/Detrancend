using System.IO;
using System.Xml;
using Detranscend.XmlCreator;

namespace Detranscend.Transcendence
{
    public class TXMLFile
    {
        public XmlDocument OriginalDocument { get; }
        public string OriginalPath { get; }

        public TXMLFile(string path)
        {
            OriginalPath = path;
            OriginalDocument = XmlParser.ParseDocument(File.ReadAllText(path), out _);
        }
    }
}
