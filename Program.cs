using System.Net;
using System.Text.RegularExpressions;
using System.Text;
internal class Program
{
    private static void Main(string[] args)
    {
        HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("https://philpapers.org/");
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        Console.WriteLine("Сайт має заголовки:");
        for (int i = 0; i < response.Headers.Count; ++i)
            Console.WriteLine("\nHeader Name: {0}, Value : {1}", response.Headers.Keys[i], response.Headers[i]);

    }
}