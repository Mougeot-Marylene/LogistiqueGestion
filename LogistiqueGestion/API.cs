using System.Text.Json;

namespace LogistiqueGestion;

internal class API
{
    private readonly HttpClient _httpClient = new();

    public async Task<T> GetRESTAsync<T>(string url)
    {
        var response = await GetHttpClient(url);

        if (response.IsSuccessStatusCode)
        {
            string jsonText = await response.Content.ReadAsStringAsync();


            var result = JsonSerializer.Deserialize<T>(
                jsonText,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });


            return result;
        }
        else
            throw new HttpRequestException();
    }

    private async Task<HttpResponseMessage> GetHttpClient(string url)
    {
        return await _httpClient.GetAsync(url);
    }
}