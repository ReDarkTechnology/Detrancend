using Detranscend.XmlCreator;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace Detranscend.Transcendence
{
    public static class UnidManager
    {
        public static List<Unid> Entities { get; } = new List<Unid>();

        /// <summary>
        /// This one finds the Unid from an id like 0x00000001
        /// </summary>
        public static Unid? GetUnid(int id)
        {
            return Entities.FirstOrDefault(unid => unid.Id == id);
        }

        /// <summary>
        /// This one finds the Unid from a name like unidEasyEternity
        /// </summary>
        public static Unid? GetUnid(string name)
        {
            return Entities.Find(unid => unid.Name == name);
        }

        /// <summary>
        /// This one finds the Unid from a name like unidEasyEternity
        /// </summary>
        public static Unid CreateOrGetUnid(string name)
        {
            var unid = GetUnid(name);
            if (unid == null)
            {
                unid = new Unid(-1, name);
                Entities.Add(unid);
            }
            return unid;
        }


        /// <summary>
        /// This one finds the Unid from a reference like &unidEasyEternity;
        /// </summary>
        public static Unid? GetUnidFromReference(string name)
        {
            foreach (Unid unid in Entities)
            {
                var str = unid.ToString();
                if (str == name)
                    return unid;
            }
            return null;
            // return Entities.Find(unid => unid.ToString() == name);
        }

        public static bool ContainsUnid(XmlElement element) => element.GetAttributeNode("UNID") != null || element.GetAttributeNode("unid") != null;

        public static Unid CreateOrGetUnidFromReference(string name)
        {
            var unid = GetUnidFromReference(name);
            if (unid == null)
            {
                unid = new Unid(-1, name);
                Entities.Add(unid);
            }
            return unid;
        }

        public static void AssignReferenceTo(Unid? unid, TElement? element)
        {
            if (unid != null && element != null)
                unid.Source = element;
        }

        public static void LoadEntitiesFromXml(string xmlContent) => LoadEntitiesFromXml(XmlParser.ParseDocument(xmlContent, out _));
        public static void LoadEntitiesFromXml(XmlDocument xmlDoc)
        {
            // Access the DOCTYPE section containing <!ENTITY ...> declarations
            XmlDocumentType? docType = xmlDoc.FirstChild as XmlDocumentType;
            if (docType != null)
            {
                // Extract the raw content from the DOCTYPE's internal subset
                string? entityDefinitions = docType.InternalSubset;

                // Find all entity declarations within the internal subset
                var entityRegex = new System.Text.RegularExpressions.Regex(@"<!ENTITY\s+(\S+)\s+""([^""]+)"">");
                if (entityDefinitions == null) { return; }

                var matches = entityRegex.Matches(entityDefinitions);

                foreach (System.Text.RegularExpressions.Match match in matches)
                {
                    if (match.Groups.Count == 3)
                    {
                        string entityName = match.Groups[1].Value;
                        string hexId = match.Groups[2].Value;

                        if (int.TryParse(hexId, System.Globalization.NumberStyles.HexNumber, null, out int id))
                        {
                            Unid unid = new Unid(id, entityName);
                            if (!Entities.Contains(unid))
                                Entities.Add(unid);
                        }
                    }
                }
            }
        }
    }
}
