using Proxy.Core;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace Proxy.RemoteProxy
{
    public class RemoteProxyRepository : IUserRepositoryRemote
    {
        private readonly HttpClient _httpClient;

        public RemoteProxyRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<UserData> GetUserDataById(int id)
        {
            try
            {
                var response = await _httpClient.GetAsync($"https://localhost:7051/User/get-user/{id}");
                if (!response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"Failed to fetch user data. HTTP Status: {response.StatusCode}");
                    return null;
                }

                var userData = await response.Content.ReadFromJsonAsync<UserData>();
                if (userData != null)
                {
                    Console.WriteLine("Getting user by remote api");
                }
                else
                {
                    Console.WriteLine($"No user found with ID {id}.");
                }
                return userData;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching user data: {ex.Message}");
                return null;
            }
        }

        public async Task InsertUserData(UserData userData)
        {
            if (userData == null)
            {
                Console.WriteLine("Invalid user data provided.");
                return;
            }
            Console.WriteLine("Inserting new user data.");
            try
            {
                var response = await _httpClient.PostAsJsonAsync("https://localhost:7051/User/insert", userData);
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"User data for {userData.Name} inserted successfully.");
                }
                else
                {
                    Console.WriteLine($"Failed to insert user data. HTTP Status: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inserting user data: {ex.Message}");
            }
        }

        public async Task RemoveUserData(int id)
        {
            Console.WriteLine($"Removing user data for user with ID: {id}");
            try
            {
                var response = await _httpClient.DeleteAsync($"https://localhost:7051/User/remove/{id}");
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"User data for ID {id} removed successfully.");
                }
                else
                {
                    Console.WriteLine($"Failed to remove user data for ID {id}. HTTP Status: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error removing user data: {ex.Message}");
            }
        }
    }
}