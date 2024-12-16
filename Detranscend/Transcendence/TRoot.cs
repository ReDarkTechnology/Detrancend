using Detranscend.XmlCreator;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Detranscend.Transcendence
{
    public class TRoot : TElement
    {
        public string OriginalPath { get; set; }
        public override string ElementName => "TranscendenceBase";
        public List<TEntity> Entities { get; set; } = new();
        public List<TElement> Elements { get; set; } = new();

        public TRoot(string filePath)
        {
            OriginalPath = filePath;
            OnProcessDocument(File.ReadAllText(filePath));
        }

        public virtual void OnProcessDocument(string data)
        {
            XmlDocument document = XmlParser.ParseDocument(data, out List<TEntity> entities);

            foreach (TEntity entity in entities)
            {
                AddEntity(entity);
                if (entity.Name == null) continue; 

                var unid = UnidManager.CreateOrGetUnid(entity.Name);
                unid.Id = entity.Id;
            }

            OnLoad(document);
        }

        public virtual void OnLoad(XmlDocument document)
        {
            Load(document.DocumentElement!);

            Console.WriteLine($"Parsing TRoot: {Path.GetFileName(OriginalPath)} ({Unid})");

            // TODO: Properly load child elements
            foreach (XmlNode childNode in document.ChildNodes)
            {
                if (childNode is XmlElement childElement)
                {
                    if (UnidManager.ContainsUnid(childElement))
                    {
                        TElement newElement = new();
                        newElement.Load(childElement);
                        Elements.Add(newElement);
                    }
                }
            }
        }

        public void AddEntity(TEntity entity) => Entities.Add(entity);
        public void AddElement(TElement element) => Elements.Add(element);
        public void RemoveEntity(TEntity entity) => Entities.Remove(entity);
        public void RemoveElement(TElement element) => Elements.Remove(element);
    }
}
