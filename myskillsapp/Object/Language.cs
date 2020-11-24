using Newtonsoft.Json;
using System.Collections.Generic;

namespace myskillsapp.Object
{
    public class Language
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Framework> Framework { get; set; }

        [JsonConstructor]
        public Language(int id, string name, List<Framework> frameworks)
        {
            this.Id = id;
            this.Name = name;
            this.Framework = frameworks;
        }

        public Language(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            this.Framework = null;
        }
    }
}
