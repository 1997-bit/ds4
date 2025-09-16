using System;

namespace Laboratorio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.FirstName = "Juan";
            client.LastName = "García";
            client.Age = 15;
            client.Id = 1;

            Console.WriteLine(client.GetFullName());
        }
    }

    public class Client
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public ushort Age { get; set; }


        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
