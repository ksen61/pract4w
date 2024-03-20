using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Pract44WPF
{
    public class TesterClass
    {
        public static void Serialization<T>(List<T> items)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Test.json");
            string json = JsonConvert.SerializeObject(items);
            File.WriteAllText(path, json);

        }
        public static List<T> Deserialization<T>()
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Test.json");
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                List<T> items = JsonConvert.DeserializeObject<List<T>>(json) ?? new List<T>();
                return items;
            }

            return new List<T>();

        }
    }
}
