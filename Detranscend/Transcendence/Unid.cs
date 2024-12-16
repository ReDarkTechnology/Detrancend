namespace Detranscend.Transcendence
{
    public class Unid
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public object? Source { get; set; }

        public bool IsValid => Id != -1;

        public Unid(int id = -1, string? name = "Undentified", object? source = null)
        {
            name ??= "Undentified";
            name = name.StartsWith("&") ? name.Substring(1) : name;
            name = name.EndsWith(";") ? name.Substring(0, name.Length - 1) : name;

            Id = id;
            Name = name;
            Source = source;
        }

        public override string ToString()
        {
            return $"&{Name};";
        }

        public string ToSerializableString()
        {
            return $"&tamp;{Name};";
        }

        public override bool Equals(object? obj)
        {
            return obj is Unid unid && (Id == unid.Id || Name == unid.Name);
        }

        public override int GetHashCode()
        {
            return Id ^ Name.GetHashCode();
        }

        public static implicit operator Unid(int id)
        {
            return new Unid(id);
        }

        public static implicit operator Unid(string name)
        {
            return new Unid(-1, name);
        }
    }
}
