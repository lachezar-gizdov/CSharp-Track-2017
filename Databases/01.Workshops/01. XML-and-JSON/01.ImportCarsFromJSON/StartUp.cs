using ImportCarsFromJSON.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace ImportCarsFromJSON
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var json = File.ReadAllText("../../data/data.json");

            JArray array = JArray.Parse(json);

            CarJsonModel car = JsonConvert.DeserializeObject<CarJsonModel>(json);
            Console.WriteLine(car);
        }
    }
}