using System;
using System.Net;

class Program
{
    public static void Main(string[] args)
    {
        if (args.Length != 2) {
            throw new InvalidOperationException("Usage: download.exe <url> <file>");
        }
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12 | SecurityProtocolType.Tls13;
        Console.WriteLine("Downloading " + args[0] + " to " + args[1] + "...");
        var client = new WebClient();
        client.DownloadFile(args[0], args[1]);
        Console.WriteLine("Done.");
    }
}