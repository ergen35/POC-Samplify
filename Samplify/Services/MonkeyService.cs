using Samplify.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Samplify.Services;

public class MonkeyService
{
    HttpClient _httpClient;
    List<Monkey> monkeys = new List<Monkey>();

    public MonkeyService()
    {
        _httpClient = new HttpClient();
    }


    public async Task<List<Monkey>> GetMonkeysAsync()
    {
        //if(monkeys.Count == 0)
        //{
        
            using var stream = await FileSystem.OpenAppPackageFileAsync("monkeys.json");
            using var reader = new StreamReader(stream);
            var stringContent = await reader.ReadToEndAsync();

            monkeys = JsonSerializer.Deserialize<List<Monkey>>(stringContent);
        //}

        return monkeys;
    }
}
