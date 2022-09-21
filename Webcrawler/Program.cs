using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Xml;

public class Program
{
    public static List<string> locations;
    public static void Main()
    {
        locations = new List<string>(200);
        WebRequest req = WebRequest.Create(@"https://www.ah.nl/sitemaps/entities/products/detail.xml");

        HttpClient client = new HttpClient();
        HttpResponseMessage response = client.Send(new HttpRequestMessage(HttpMethod.Get, "https://www.ah.nl/sitemaps/entities/products/detail.xml"));
        Stream str = response.Content.ReadAsStream();
        XmlReader reader = XmlReader.Create(str);
        while(reader.Read())
        {
            string name = reader.Name;
            XmlNodeType type = reader.NodeType;
            if(type == XmlNodeType.Text)
            {
                string location = reader.Value;
                locations.Add(location);
            }
        }
        return;
    }
}

