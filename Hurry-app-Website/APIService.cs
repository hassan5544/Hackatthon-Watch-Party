using Newtonsoft.Json;
using System.Net.Http;

namespace Hurry_app_Website
{
    public interface IUserInterface
    {
        Task<User> Login(string username, string Password);



    }
    public class APIService
    {
        
        public async Task<User> Login(string username, string Password)
        {
            var client = new HttpClient();
            string url = $"https://localhost:7191/api/{username}/{Password}";
            client.BaseAddress = new Uri(url);
            HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
            if (response.IsSuccessStatusCode)
            {
                string content = response.Content.ReadAsStringAsync().Result;
                User user = JsonConvert.DeserializeObject<User>(content);
                return await Task.FromResult(user);
            }
            return null!;
        }
    }
}
