using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
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
    class MoodsData
    {
        public string data;
    }
    class PetTypesData
    {
        public string data;
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
        public MoodsData GetMoods(string path)
        {
            MoodsData returnvalue = new MoodsData();
            HttpResponseMessage response = client.GetAsync(path).Result;
            if (response.IsSuccessStatusCode)
            {
                string str = response.Content.ReadAsStringAsync().Result;
                returnvalue = JsonSerializer.Deserialize<MoodsData>(str);
            }
            return returnvalue;
        }
        public PetTypesData GetPetTypes(string path)
        {
            PetTypesData returnvalue = new PetTypesData();
            HttpResponseMessage response = client.GetAsync(path).Result;
            if (response.IsSuccessStatusCode)
            {
                string str = response.Content.ReadAsStringAsync().Result;
                returnvalue = JsonSerializer.Deserialize<PetTypesData>(str);
            }
            return returnvalue;
        }
        public async Task<Uri> CreateMood(string newMood)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                "api/moods", newMood);
            response.EnsureSuccessStatusCode();
            return response.Headers.Location;
        }
        public async Task<Uri> CreatePetType(string newType)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                "api/pettype", newType);
            response.EnsureSuccessStatusCode();
            return response.Headers.Location;
        }
        public async Task<Uri> CreatePet(Pet newPet)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                "api/pets", newPet);
            response.EnsureSuccessStatusCode();
            return response.Headers.Location;
        }
        public async Task<Uri> CreateUser(User newUser)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                "api/users", newUser);
            response.EnsureSuccessStatusCode();
            return response.Headers.Location;
        }
        public async Task<PetsData> UpdatePetAsync(PetsData changedPet)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync($"api/pets/{changedPet.data.Id}", changedPet);
            response.EnsureSuccessStatusCode();
            string str = response.Content.ReadAsStringAsync().Result;
            changedPet = JsonSerializer.Deserialize<PetsData>(str);
            return changedPet;
        }
        public async Task<UsersData> UpdateUserAsync(UsersData changedUser)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync($"api/users/{changedUser.data.Id}", changedUser);
            response.EnsureSuccessStatusCode();
            string str = response.Content.ReadAsStringAsync().Result;
            changedUser = JsonSerializer.Deserialize<UsersData>(str);
            return changedUser;
        }
        public async Task<HttpStatusCode> DeleteUserAsync(string id)
        {
            HttpResponseMessage response = await client.DeleteAsync(
                $"api/users/{id}");
            return response.StatusCode;
        }
        public async Task<HttpStatusCode> DeletePetAsync(string id)
        {
            HttpResponseMessage response = await client.DeleteAsync(
                $"api/pets/{id}");
            return response.StatusCode;
        }
        public async Task<HttpStatusCode> DeleteMoodAsync(string id)
        {
            HttpResponseMessage response = await client.DeleteAsync(
                $"api/moods/{id}");
            return response.StatusCode;
        }
        public async Task<HttpStatusCode> DeletePetTypeAsync(string id)
        {
            HttpResponseMessage response = await client.DeleteAsync(
                $"api/pettype/{id}");
            return response.StatusCode;
        }
    }
}
