using System.Net;

namespace Populate_Database_Tool
{
    internal class GetData
    {
        public static string GetSource(string url)
        {
            WebClient Client = new WebClient();
            string Source = Client.DownloadString(url);
            return Source;
        }
    }
}