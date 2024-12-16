using Detranscend.Transcendence.Specification;
using System;
using System.IO;
using System.Windows.Forms;
using YamlDotNet.Serialization;

namespace Detranscend
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Settings.Reload();
            var yamlData = new TConfig() { Name = "Test", CapitalUnid = true, Attributes = new() { 
                new TConfigAttribute() { Name = "name", Type = "string" },
                new TConfigAttribute() { Name = "isEvil", Type = "bool" },
                new TConfigAttribute() { Name = "id", Type = "hex" },
            } };

            var serializer = new SerializerBuilder()
                .Build();
            var yaml = serializer.Serialize(yamlData);
            File.WriteAllText("config.yaml", yaml);

            ApplicationConfiguration.Initialize();
            Application.Run(MainForm.Instance);
            Settings.Save();
        }
    }
}