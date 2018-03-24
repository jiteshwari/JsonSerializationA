using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;


namespace Json
{
    [DataContract]
        public class Client
        {
            [DataMember]
            public string Name { get; set; }
            [DataMember]
            public int Age { get; set; }
           [DataMember]
           public Double Salary  { get; set; }
        [DataMember]
        public string Address { get; set; }
    }
       
        class EmployeeAA
        {
        static MemoryStream stream;
        static Client[] jsonData;
        static DataContractJsonSerializer jsonSerializer;

        static void Add()
        {
            Console.Write("Enter total Number of details : ");
            int n = Convert.ToInt32(Console.ReadLine());
            jsonData = new Client[n];
            for (int i = 0; i<n; i++)
            {
                Client obj = new  Client();
                Console.Write("Enter Name : ");
                obj.Name = Console.ReadLine();
                Console.Write("Enter Age : ");
                obj.Age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Salary : ");
                obj.Salary = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Address : ");
                obj.Address = Console.ReadLine();

                jsonData[i] = obj;
            }

        }

        static void JsonSerialize()
        {
            jsonSerializer = new DataContractJsonSerializer(typeof(Client[]));
            stream = new MemoryStream();
            jsonSerializer.WriteObject(stream,jsonData);
            stream.Position = 0;
        }

        static void JsonDeSerialize()
        {
            Client[] obj = (Client[])jsonSerializer.ReadObject(stream);
            foreach (Client var in obj)
            {
                Console.WriteLine(string.Concat("Name is "+ var.Name+ " "  + "Years Old" + var.Age + ""  +"Salary is" + var.Salary + " " +"Address is" + var.Address ));
            }
        }
        static void Main(string[] args)
            {
            Add();
            JsonSerialize();
            JsonDeSerialize();
          Console.ReadKey();
            }
        }   
}
