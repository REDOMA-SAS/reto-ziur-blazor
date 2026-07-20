using System.Net.Http.Json;
using RetoZiur.Web.Models;

namespace RetoZiur.Web.Services;

public class ItemService
{
    private readonly HttpClient _http;

    public ItemService(HttpClient http)
    {
        _http = http;
    }

    public async Task<List<Item>> ObtenerItemsAsync()
    {
        var resultado = await _http.GetFromJsonAsync<List<Item>>(
            "Ziur.API/basedatos_01/ZiurServiceRest.svc/api/DocumentosFillsCombos");
        return resultado ?? new List<Item>();
    }
}