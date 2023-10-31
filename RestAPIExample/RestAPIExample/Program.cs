using RestSharp;
using System;
using System.Net.Http.Headers;
using System.Text.Json;

namespace ApiExample
{
    class Api
    {
        static void Main(string[] args)
        {
            String url = "https://dummyjson.com/carts";
            RestClient client = new RestClient(url);
            var request = new RestRequest(url, Method.Get);
            var response = client.Execute(request);

            Console.WriteLine(JsonSerializer.Serialize(response));
            Console.ReadKey();
        }
    }
}