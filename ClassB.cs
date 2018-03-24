using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json
{
    class ClassB
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Address { set; get; }
    }
    class Serializatoin
    {
        static void Main(string[] args)
        {
            ClassB b = new ClassB();
            {
                b.Id = 12;
                b.Name = "BS";
                b.Address = "blr";
            };
            string serializedJson = JsonConvert.SerializeObject(b);

            Console.WriteLine(serializedJson);
            Console.ReadKey();
        }
    }
}
