using System;
using System.Text.Json;

namespace args2json
{
    class Program
    {
        static void Main(string[] args)
        {
            var jsonOptions = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            Console.WriteLine(JsonSerializer.Serialize(args, jsonOptions));
        }
    }
}
