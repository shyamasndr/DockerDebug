using System;
using System.IO;
using System.Threading;
using Newtonsoft.Json;

namespace jsonfile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Give yourself 30secs to launch the container and add a breakpoint
            while (true)
            {
                Thread.Sleep(3000);

                var person = JsonConvert.DeserializeObject<Person>(File.ReadAllText("myfile.json"));
                Console.WriteLine(person.Name + person.Age);

            }
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
