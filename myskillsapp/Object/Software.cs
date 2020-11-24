using Newtonsoft.Json;

namespace myskillsapp.Object
{
    public class Software
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        [JsonConstructor]
        public Software(int id, string name, string type)
        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
        }
    }
}
