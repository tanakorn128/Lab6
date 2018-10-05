using System;
using System.Net;
using System.IO;


namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            string value = client.DownloadString("http://www.kmitl.ac.th");
            Console.WriteLine("---WebClient result---");
            Console.WriteLine(value.Length);
            Console.WriteLine(value);
            StreamWriter outtxt = new StreamWriter("webload.html");
            outtxt.Write(value);
            outtxt.Dispose();
        }
    }
}
