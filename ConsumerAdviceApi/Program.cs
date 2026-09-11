using ConsumerAdviceApi.Models;
using static System.Console;

var enderecoUrl = "https://api.adviceslip.com/advice";

WriteLine($"Consultando o endereço na url: {enderecoUrl}");

var client = new HttpClient();

try
{
    HttpResponseMessage response = await client.GetAsync(enderecoUrl);
    response.EnsureSuccessStatusCode();

    string respostaApi = await response.Content.ReadAsStringAsync();

    AdviceResponse? advice = System.Text.Json.JsonSerializer.Deserialize<AdviceResponse>(respostaApi);

    WriteLine($"\nToday's advice:\n" + advice?.Slip?.Advice);

}
catch (Exception e)
{
    WriteLine($"Ocorreu um erro ao consultar o endereço: {e.Message}");
}