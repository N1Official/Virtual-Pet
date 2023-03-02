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
    class DataHeader<T> { 
        public T data { get; set; }
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
        
        public Pet[] GetPets(string path) 
        {
            Pet[] returnvalue = new Pet[0];
            HttpResponseMessage response = client.GetAsync(path).Result;
            if (response.IsSuccessStatusCode)
            {
                string str = response.Content.ReadAsStringAsync().Result;
                returnvalue = JsonSerializer.Deserialize<DataHeader<Pet[]>>(str)!.data;
            }
            return returnvalue;
        }
        public User[] GetUsers(string path)
        {
            User[] returnvalue = new User[0];
            HttpResponseMessage response = client.GetAsync(path).Result;
            if (response.IsSuccessStatusCode)
            {
                string str = response.Content.ReadAsStringAsync().Result;
                returnvalue = JsonSerializer.Deserialize<DataHeader<User[]>>(str)!.data;
            }
            return returnvalue;
        }
        public Mood[] GetMoods(string path)
        {
            Mood[] returnvalue = new Mood[0];
            HttpResponseMessage response = client.GetAsync(path).Result;
            if (response.IsSuccessStatusCode)
            {
                string str = response.Content.ReadAsStringAsync().Result;
                returnvalue = JsonSerializer.Deserialize<DataHeader<Mood[]>>(str)!.data;
            }
            return returnvalue;
        }
        public PetType[] GetPetTypes(string path)
        {
            PetType[] returnvalue = new PetType[0];
            HttpResponseMessage response = client.GetAsync(path).Result;
            if (response.IsSuccessStatusCode)
            {
                string str = response.Content.ReadAsStringAsync().Result;
                returnvalue = JsonSerializer.Deserialize<DataHeader<PetType[]>>(str)!.data;
            }
            return returnvalue;
        }
        public async Task<Uri> CreateMood(Mood newMood)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                "api/moods", newMood);
            response.EnsureSuccessStatusCode();
            return response.Headers.Location;
        }
        public async Task<Uri> CreatePetType(PetType newType)
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
        public async Task<Pet> UpdatePetAsync(Pet changedPet)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync($"api/pets/{changedPet.id}", changedPet);
            response.EnsureSuccessStatusCode();
            response.Content.Headers.ContentType = new MediaTypeWithQualityHeaderValue("application/json");
            string str = response.Content.ReadAsStringAsync().Result;
            changedPet = JsonSerializer.Deserialize<Pet>(str)!;
            return changedPet;
        }
        public async Task<User> UpdateUserAsync(User changedUser)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync($"api/users/{changedUser.id}", changedUser);
            response.EnsureSuccessStatusCode();
            response.Content.Headers.ContentType = new MediaTypeWithQualityHeaderValue("application/json");
            string str = response.Content.ReadAsStringAsync().Result;
            changedUser = JsonSerializer.Deserialize<User>(str)!;
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
        public async Task<HttpStatusCode> DeletePetTypeAsync(string typename)
        {
            HttpResponseMessage response = await client.DeleteAsync(
                $"api/pettype/{typename}");
            return response.StatusCode;
        }
    }
}
