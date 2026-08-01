using System.Net.Http.Json;

namespace MiBiblioteca.Web.Services;

public class ApiClient
{
    private readonly HttpClient http;


    public ApiClient(HttpClient http)
    {
        this.http = http;
    }


    public async Task<T?> GetAsync<T>(string url)
    {
        return await http.GetFromJsonAsync<T>(url);
    }


    public async Task<HttpResponseMessage> PostAsync<T>(
        string url,
        T data)
    {
        return await http.PostAsJsonAsync(url, data);
    }


    public async Task<HttpResponseMessage> PutAsync<T>(
        string url,
        T data)
    {
        return await http.PutAsJsonAsync(url, data);
    }


    public async Task<HttpResponseMessage> DeleteAsync(
        string url)
    {
        return await http.DeleteAsync(url);
    }
}