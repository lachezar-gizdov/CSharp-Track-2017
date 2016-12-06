using System;
using System.Text;

class ParseURL
{
    static void Main()
    {
        StringBuilder url = new StringBuilder(Console.ReadLine());

        URLParse(url);
    }


    static void URLParse(StringBuilder url)
    {
        int index = 0;
        string protocol = string.Empty;
        string server = string.Empty;
        string resource = string.Empty;

        index = url.ToString().IndexOf(':');

        for (int i = 0; i < index; i++)
        {
            protocol += url[i];
        }
        url.Remove(0, protocol.Length + 3);

        index = url.ToString().IndexOf('/');

        for (int i = 0; i < index; i++)
        {
            server += url[i];
        }

        url.Remove(0, server.Length);
        resource = url.ToString();

        Console.WriteLine("[protocol] = {0}", protocol);
        Console.WriteLine("[server] = {0}", server);
        Console.WriteLine("[resource] = {0}", resource);
    }
}