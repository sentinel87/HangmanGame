using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace HangmanGame.Helpers
{
    public class JsonHelper: IGameDataSource
    {
        public List<string> GetGameData()
        {
            List<string> results = new List<string>();

            using (StreamReader r = new StreamReader("answers.json"))
            {
                string jsonData = r.ReadToEnd();
                results = JsonSerializer.Deserialize<List<string>>(jsonData);
            }

            return results;
        }
    }
}
