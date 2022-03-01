using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace MusicGraphQL
{
    public class MusicCollectionService
    {
        private const string JsonFile = "musics.json";
        public static MusicCollection FromJson()
        {
            if (File.Exists(JsonFile))
            {
                var jsonContent = File.ReadAllText(JsonFile, Encoding.UTF8);
                return JsonConvert.DeserializeObject<MusicCollection>(jsonContent);
            }
            return new();
        }

        public static void ToJson(MusicCollection musicCollection)
        {
            var jsonContent = JsonConvert.SerializeObject(musicCollection, new JsonSerializerSettings
            {
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new CamelCaseNamingStrategy()
                },
                Formatting = Formatting.Indented
            });
            File.WriteAllText(JsonFile, jsonContent, Encoding.UTF8);
        }
    }
}