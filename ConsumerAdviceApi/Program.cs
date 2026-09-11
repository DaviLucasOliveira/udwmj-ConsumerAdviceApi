using static System.Console;

var enderecoUrl = "https://api.adviceslip.com/advice";

WriteLine($"Consultando o endereço na url: {enderecoUrl}");

var client = new HttpClient();

try
{
    HttpResponseMessage response = await client.GetAsync(enderecoUrl);
    response.EnsureSuccessStatusCode();

    string respostaApi = await response.Content.ReadAsStringAsync();

    ConsumerAdviceApi.Models.AdviceResponse? advice = System.Text.Json.JsonSerializer.Deserialize<ConsumerAdviceApi.Models.AdviceResponse>(respostaApi);

    WriteLine($"\nToday's advice:\n" + advice?.slip?.advice);

}
catch (Exception e)
{
    WriteLine($"Ocorreu um erro ao consultar o endereço: {e.Message}");
}