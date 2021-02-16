using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;


namespace Asynchronous.Models
{
    public class AsyncMethods
    {

        public async static Task<long?> GetPageLength()
        {
            HttpClient client = new HttpClient();
            var httpMessage = await
            client.GetAsync("http://google.com");
            return
            httpMessage.Content.Headers.ContentLength;
        }
        public static async IAsyncEnumerable<long?>GetPageLengths(List<string> output, params string[] urls)
        {
            HttpClient client = new HttpClient();
            foreach (string url in urls)
            {
                output.Add($"Started request for {url}");
                var httpMessage = await
                client.GetAsync($"http://{url}");
                output.Add($"Completed request for {url}");
                yield return
                httpMessage.Content.Headers.ContentLength;
            }

        }
    }
}
