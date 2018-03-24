using Json;
using Newtonsoft.Json;
using System;

namespace Json 
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public float Salary { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
    class SerializeJSON
    {
        static void Main(string[] args)
        {
            Employee any = new Employee
            {
                ID = 32,
                Name = "JS",
                Address = "blr",
                Salary = 20000,                
                DateOfBirth = new DateTime(1995-06-19)
            };
            string serializedJson = JsonConvert.SerializeObject(any);

            Console.WriteLine(serializedJson);
            Console.ReadKey();
        }
    }

}
