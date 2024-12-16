using System.Collections.Generic;
using System.Xml;

namespace Detranscend.Transcendence
{
    public class TElement : TBase
    {
        public bool IsUnidCapital { get; private set; }
        public Unid? Unid { get; set; }
        public List<TElement> Children { get; set; } = new();

        public override XmlElement GetElement(XmlDocument document)
        {
            var element = base.GetElement(document);
            if (Unid != null)
                element.SetAttribute(IsUnidCapital ? "UNID" : "unid", Unid.ToString());
            return element;
        }

        public override void Load(XmlElement element)
        {
            base.Load(element);

            if (UnidManager.ContainsUnid(element))
            {
                IsUnidCapital = element.GetAttributeNode("UNID") != null;

                var unidString = element.GetAttribute(IsUnidCapital ? "UNID" : "unid");
                Unid = UnidManager.CreateOrGetUnidFromReference(unidString);
                UnidManager.AssignReferenceTo(Unid, this);
            }

            foreach (XmlNode node in element.ChildNodes)
            {
                if (node is XmlElement child)
                {
                    if (UnidManager.ContainsUnid(child))
                    {
                        var childElement = new TElement();
                        childElement.Load(child);
                        Children.Add(childElement);
                    }
                }
            }
        }
    }
}