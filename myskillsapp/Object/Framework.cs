using Newtonsoft.Json;

namespace myskillsapp.Object
{
    public class Framework
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public Language Language { get; set; }

        [JsonConstructor]
        public Framework(int id, string name, Language language)
        {
            this.Id = id;
            this.Name = name;
            this.Language = language;
        }

        public Framework(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            this.Language = null;
        }
    }
}
