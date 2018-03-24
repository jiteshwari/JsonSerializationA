using Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonProject
{
    class DeserializeJSON
    {
        static void Deserialize()
        {
            string data = @"{'ID': 32,
                            'Name':'JS',
                            'DateOfBirth':'1995-06-19'
                            }";
            Employee obj = JsonConvert.DeserializeObject<Employee>(data);
            Console.WriteLine("ID:" + obj.ID);
            Console.WriteLine("Name:" + obj.Name);
            Console.WriteLine("DateOfBirth:" + obj.DateOfBirth);

        }
        static void Main(string[] args)
        {

            Deserialize();
            Console.ReadKey();
        }
    }
}
