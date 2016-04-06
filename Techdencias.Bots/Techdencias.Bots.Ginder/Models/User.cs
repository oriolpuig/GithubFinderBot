using Newtonsoft.Json.Linq;

namespace Techdencias.Bots.Ginder.Models
{
    public class User
    {
        public User(string dataJSON)
        {
            JObject jObject = JObject.Parse(dataJSON);
            //JToken jUser = jObject["user"];
            name = (string)jObject["name"];
            login = (string)jObject["login"];
            id = (int)jObject["id"];
            avatar_url = (string)jObject["avatar_url"];
            html_url = (string)jObject["html_url"];
            company = (string)jObject["company"];
            blog = (string)jObject["blog"];
            location = (string)jObject["location"];
            followers = (int)jObject["followers"];
            following = (int)jObject["following"];
        }

        public string login { get; set; }

        public int id { get; set; }

        public string avatar_url { get; set; }

        public string html_url { get; set; }

        public string name { get; set; }

        public string company { get; set; }

        public string blog { get; set; }

        public string location { get; set; }

        public int followers { get; set; }

        public int following { get; set; }
    }
}