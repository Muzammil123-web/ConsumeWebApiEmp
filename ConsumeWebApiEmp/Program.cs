// See https://aka.ms/new-console-template for more information
using ConsumeWebApiEmp.Model;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
class Program
{
    static async Task Main(string[] args)
    {

        string Url = "https://localhost:7083/api/Employe";
        await GetItemEmplyes(Url);

        await AddEmpyer(Url, new Employer() { JobId = 9, Name = "SHaikMuz", JobDescription = "I love taking good Vibes", JobName = "Photography" });

        await UpdateEmplyer(Url, 9, new Employer() { JobId = 9, Name = "SHaikMuzUpdate", JobDescription = "I love taking good Vibes", JobName = "Photography" });

        await DeleteEmp(Url, 3);

    }
    public static async Task GetItemEmplyes(string uri)
    {
        using (var client = new HttpClient())
        {
            client.BaseAddress = new Uri(uri);
            HttpResponseMessage response = await client.GetAsync(uri);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            Console.WriteLine("Respnse Recieved");
            Console.WriteLine(content);
        }


    }

    static async Task AddEmpyer(string apiUrl, Employer emp)
    {
        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(apiUrl, emp);
            response.EnsureSuccessStatusCode(); // Throw if not a success code

            string content = await response.Content.ReadAsStringAsync();
            Console.WriteLine("AddBook Response:");
            Console.WriteLine(content);
        }
    }

    static async Task UpdateEmplyer(string apiUrl, int JobId, Employer updatedEmp)
    {
        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.PutAsJsonAsync($"{apiUrl}/{JobId}", updatedEmp);
            response.EnsureSuccessStatusCode(); // Throw if not a success code

            string content = await response.Content.ReadAsStringAsync();
            Console.WriteLine("UpdateBook Response:");
            Console.WriteLine(content);
        }
    }

    static async Task DeleteEmp(string apiUrl, int JobId)
    {
        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.DeleteAsync($"{apiUrl}/{JobId}");
            response.EnsureSuccessStatusCode(); // Throw if not a success code

            string content = await response.Content.ReadAsStringAsync();
            Console.WriteLine("DeleteBook Response:");
            Console.WriteLine(content);
        }
    }

}