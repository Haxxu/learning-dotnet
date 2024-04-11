using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Net.Http;


// string url = "https://xuanthulab.net/lap-trinh/csharp/?page=3#acff";
// var uri = new Uri(url);
// var uritype = typeof(Uri);
// uritype.GetProperties().ToList().ForEach(property =>
// {
//     Console.WriteLine($"{property.Name,15} {property.GetValue(uri)}");
// });
// Console.WriteLine($"Segments: {string.Join(",", uri.Segments)}");


// string url = "https://www.bootstrapcdn.com";
// var uri = new Uri(url);
// var hostEntry = Dns.GetHostEntry(uri.Host);
// Console.WriteLine($"Host {uri.Host} have IPs");
// hostEntry.AddressList.ToList().ForEach(ip => Console.WriteLine(ip));



// var ping = new Ping();
// var pingReply = ping.Send("google.com.vn");
// Console.WriteLine(pingReply.Status);
// if (pingReply.Status == IPStatus.Success)
// {
//     Console.WriteLine(pingReply.RoundtripTime);
//     Console.WriteLine(pingReply.Address);
// }



// HttpClient
using var httpClient = new HttpClient();

httpClient.DefaultRequestHeaders.Add("Accept", "text/html,application/xhtml+xml+json");

// HttpRequestMessage response = await httpClient.GetAsync(url);
