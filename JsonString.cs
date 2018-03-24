using Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonProject
{
    class JsonString
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        static void Serialize()
        {
            var userlist = "{\"ID\":1,\"Name\":\"JS\",\"Address\":\"Asoga\"}";

            JsonString obj = JsonConvert.DeserializeObject<JsonString>(userlist);
            Console.WriteLine("ID:" + obj.ID);
            Console.WriteLine("Name:" + obj.Name);
            Console.WriteLine("Address:" + obj.Address);

        }
        static void Main(string[] args)
        {

            Serialize();
            Console.ReadKey();
        }
    }
}
