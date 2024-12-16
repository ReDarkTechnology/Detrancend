using Detranscend.Transcendence.Specification;
using System.Collections.Generic;
using System.Xml;

namespace Detranscend.Transcendence
{
    public class TBase
    {
        public string TagName { get; set; }
        public virtual string ElementName => "TranscendenceElement";
        public TConfig? Config { get; set; }
        public List<TAttribute> Attributes { get; set; } = new();

        /// <summary>
        /// Gets the XML form of the element
        /// </summary>
        public virtual XmlElement GetElement(XmlDocument document)
        {
            var element = document.CreateElement(ElementName);
            return element;
        }

        /// <summary>
        /// Resolves UNID and loads all the other attributes and components based on the inheriting class
        /// </summary>
        public virtual void Load(XmlElement element)
        {
            TagName = element.Name;
            foreach (XmlAttribute attribute in element.Attributes)
            {
                if (Config != null)
                {
                    var xmlAttribute = Config.Attributes.Find(val => val.Name == attribute.Name);
                    if (xmlAttribute != null)
                    {
                        var attributeInstance = new TAttribute() { 
                            Name = xmlAttribute.Name, 
                            Type = xmlAttribute.Type, 
                            Value = attribute.Value
                        };
                        Attributes.Add(attributeInstance);
                    }
                    else
                    {
                        var attributeInstance = new TAttribute()
                        {
                            Name = attribute.Name,
                            Value = attribute.Value
                        };
                        Attributes.Add(attributeInstance);
                    }
                }
            }
        }
    }

    public class TAttribute
    {
        public string? Name { get; set; } = "attribute";
        public string Type { get; set; } = "string";
        public string? Value { get; set; }

        public void SetValue(bool value) => Value = value.ToString();
        public void SetValue(int value) => Value = value.ToString();
        public void SetValue(string value) => Value = value.ToString();
        public void SetValue(Unid unid) => Value = unid.ToString();

        public bool GetBool(bool defaultValue = false) => Value == null ? defaultValue : Value.ToBool();
        public int GetInt(int defaultValue = 0) => Value == null ? defaultValue : Value.ToInt();
        public string GetString(string defaultValue = "") => Value ?? defaultValue;
        public Unid GetUnid() => Value == null ? new Unid() : Value.ToUnid();

        public override string ToString() => $"{Name}={Value}";
    }
}
