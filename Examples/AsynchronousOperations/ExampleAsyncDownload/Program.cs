using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ExampleAsyncDownload
{
    class Program
    {
        static readonly HttpClient _httpClient = new HttpClient()
        {
            MaxResponseContentBufferSize = 1_000_000
        };

        static readonly string[] _urlList = new string[]
        {
            "https://docs.microsoft.com",
            "https://docs.microsoft.com/aspnet/core",
            "https://docs.microsoft.com/azure",
            "https://docs.microsoft.com/azure/devops",
            "https://docs.microsoft.com/dotnet",
            "https://docs.microsoft.com/dynamics365",
            "https://docs.microsoft.com/education",
            "https://docs.microsoft.com/enterprise-mobility-security",
            "https://docs.microsoft.com/gaming",
            "https://docs.microsoft.com/graph",
            "https://docs.microsoft.com/microsoft-365",
            "https://docs.microsoft.com/office",
            "https://docs.microsoft.com/powershell",
            "https://docs.microsoft.com/sql",
            "https://docs.microsoft.com/surface",
            "https://docs.microsoft.com/system-center",
            "https://docs.microsoft.com/visualstudio",
            "https://docs.microsoft.com/windows",
            "https://docs.microsoft.com/xamarin"
        };

        static Task Main() => SumPageSizesAsync();

        /*
            The method starts by instantiating and starting a Stopwatch.
            It then includes a query that, when executed, creates a collection of tasks.
            Each call to ProcessUrlAsync in the following code returns a Task<TResult>,
            where TResult is an integer:
        */
        static async Task SumPageSizesAsync()
        {
            var stopwatch = Stopwatch.StartNew();

            IEnumerable<Task<int>> downloadTasksQuery =
                from url
                in _urlList
                select ProcessUrlAsync(url, _httpClient);

            List<Task<int>> downloadTasks = downloadTasksQuery.ToList();

            int total = 0;
            // The while loop performs the following steps for each task in the collection:
            while (downloadTasks.Any())
            {
                // Waits a call to WhenAny to identify the first task in the collection that has finished its download.
                Task<int> finishedTask = await Task.WhenAny(downloadTasks);

                // Removes that task from the collection.
                downloadTasks.Remove(finishedTask);

                total += await finishedTask;
            }

            stopwatch.Stop();

            Console.WriteLine($"\nTotal bytes returned:     {total:#,#}");
            Console.WriteLine($"Elapsed time:             {stopwatch.Elapsed}\n");
        }

        static async Task<int> ProcessUrlAsync(string url, HttpClient client)
        {
            byte[] content = await client.GetByteArrayAsync(url);
            Console.WriteLine($"{url,-60} {content.Length,10:#,#}");

            return content.Length;
        }
    }
}
