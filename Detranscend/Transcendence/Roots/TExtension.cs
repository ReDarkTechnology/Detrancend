using Detranscend.XmlCreator;
using System;
using System.IO;
using System.Xml;
using System.Collections.Generic;

namespace Detranscend.Transcendence
{
    public class TExtension : TRoot
    {
        public int ApiVersion { get; set; }
        public string? Version { get; set; }
        public string Name { get; set; }
        public string? Credits { get; set; }
        public int Release { get; set; }

        public TExtension(string filePath) : base(filePath) { }

        public override void Load(XmlElement element)
        {
            base.Load(element);

            if (int.TryParse(element.GetAttribute("apiVersion"), out int apiVersion))
                ApiVersion = apiVersion;

            Version = element.GetAttribute("version");
            Name = element.GetAttribute("name");
            Credits = element.GetAttribute("credits");

            // TODO: Properly load child elements
            foreach (XmlNode childNode in element.ChildNodes)
            {
                if (childNode is XmlElement childElement)
                {
                    TElement newElement = new();
                    newElement.Load(childElement);
                    Elements.Add(newElement);

                    Console.WriteLine($"Finished parsing TElement: {childNode.Name} ({newElement.Unid})");
                }
            }

            Console.WriteLine($"Finished parsing TExtension: {Name} ({Unid})");
        }
    }
}
