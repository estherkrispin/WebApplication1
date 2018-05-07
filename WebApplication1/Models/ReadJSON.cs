using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class ReadJSON
    {
        public static IList<Diamond> PageLoad()
        {
            //get a string represntation of the JSON pare it and create list of diamonds
            String allText = System.IO.File.ReadAllText(@"C:\Users\Esther Zino\source\repos\WebApplication1\diamond listing database.json");
            JObject jObject = JObject.Parse(allText);
            JArray jarray = (JArray)jObject["diamonds"];
            IList<Diamond> diamonds = jarray.ToObject<IList<Diamond>>();
            return diamonds;

        }
    }
}