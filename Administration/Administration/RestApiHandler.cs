using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Administration
{
    class PetsData
    {
        public Pet data;
    }
    class UsersData
    {
        public User data;
    }
    internal class RestApiHandler // connection is good, but returns with null
    {
        HttpClient client = new HttpClient();
        public RestApiHandler(string base_url)
        {
            client.BaseAddress = new Uri(base_url);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json")
                );
        }
        
        public PetsData GetPets(string path) 
        {
            PetsData returnvalue = new PetsData();
            HttpResponseMessage response = client.GetAsync(path).Result;
            if (response.IsSuccessStatusCode)
            {
                string str = response.Content.ReadAsStringAsync().Result;
                returnvalue = JsonSerializer.Deserialize<PetsData>(str);
            }
            return returnvalue;
        }
        public UsersData GetUsers(string path)
        {
            UsersData returnvalue = new UsersData();
            HttpResponseMessage response = client.GetAsync(path).Result;
            if (response.IsSuccessStatusCode)
            {
                string str = response.Content.ReadAsStringAsync().Result;
                returnvalue = JsonSerializer.Deserialize<UsersData>(str);
            }
            return returnvalue;
        }
        
    }
}
