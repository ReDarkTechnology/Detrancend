using Detranscend.Transcendence;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml;

namespace Detranscend.XmlCreator
{
    public class XmlParser
    {
        public static XmlDocument ParseDocument(string documentString, out List<TEntity> entities, bool reencode = true)
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.XmlResolver = null;

            // Parse entities from the DOCTYPE section
            entities = ExtractEntities(ref documentString);

            if (reencode)
                documentString = EncodeEntities(documentString);

            using XmlReader reader = XmlReader.Create(new StringReader(documentString), settings);
            XmlDocument document = new();
            document.Load(reader);
            return document;
        }

        static List<TEntity> ExtractEntities(ref string xmlContent)
        {
            var entities = new List<TEntity>();

            // Match and extract the DOCTYPE section
            var doctypeMatch = Regex.Match(xmlContent, @"<!DOCTYPE[^>]*\[(.*?)\]>", RegexOptions.Singleline);
            if (doctypeMatch.Success)
            {
                string doctypeContent = doctypeMatch.Groups[1].Value;

                // Extract entity definitions from the DOCTYPE section
                var entityMatches = Regex.Matches(doctypeContent, @"<!ENTITY\s+([\w\-]+)\s+""([^""]+)""\s*>");
                foreach (Match match in entityMatches)
                {
                    var entity = new TEntity { Name = match.Groups[1].Value, Id = Convert.ToInt32(match.Groups[2].Value, 16) };
                    entities.Add(entity);
                }

                // Remove the DOCTYPE section from the XML content
                xmlContent = xmlContent.Replace(doctypeMatch.Value, string.Empty);
            }

            return entities;
        }

        public static string EncodeEntities(string documentString)
        {
            // Regex to match &entityName; but exclude predefined entities in XML Standard
            string customEntitiesPattern = @"&(?!amp;|lt;|gt;|apos;|quot;)([\w\-]+);";

            // Replace only non-predefined entities
            return Regex.Replace(documentString, customEntitiesPattern, m =>
            {
                string entityName = m.Groups[1].Value;
                return $"&amp;{entityName};"; // Encode the entity reference
            });
        }
    }
}
