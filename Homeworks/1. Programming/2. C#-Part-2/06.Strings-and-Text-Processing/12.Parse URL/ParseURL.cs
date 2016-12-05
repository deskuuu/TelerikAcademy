//Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
namespace _12.Parse_URL
{
    using System;

    class ParseURL
    {
        static void GetProtocol(string input)
        {
            int index = input.IndexOf(":");
            var protocol = input.Substring(0, index);

            Console.WriteLine("[protocol] = {0}", protocol);
        }

        static string GetServer(string input)
        {
            int startIndex = input.IndexOf("//");
            int last = input.IndexOf("/", startIndex + 2);
            var server = input.Substring(startIndex + 2, last - startIndex - 2);
            return server;
        }

        static void GetResource(string input, string server)
        {
            int startIndex = input.IndexOf(server);
            var resource = input.Substring(startIndex + server.Length);

            Console.WriteLine("[resource] = {0}", resource);
        }

        static void Main()
        {
            var input = Console.ReadLine();
            GetProtocol(input);
            var server = GetServer(input);
            Console.WriteLine("[server] = {0}", server);
            GetResource(input, GetServer(input));
        }
    }
}
