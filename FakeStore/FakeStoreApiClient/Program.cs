using System.Net.Http.Json;
using FakeStoreApiClient;

var httpClient = new HttpClient();
httpClient.BaseAddress = new Uri("https://fakestoreapi.com");

// DELETE Individual Task:
var response = await httpClient.DeleteAsync("products/1");

if (response.IsSuccessStatusCode)
{
    Console.WriteLine("Product Deleted Successfully. ");
}
else
{
    Console.WriteLine("Failed To Delete Product: " +  response.StatusCode);
}

//var product = await httpClient.GetFromJsonAsync<Product>("products/1");

//product.Price = 1000;

//var response = await httpClient.PutAsJsonAsync("products/1", product);

//var newProduct = new Product
//{
//    Title = "Changed the Title",
//    Description = "Changed the Description",
//    Category = "Electronics",
//    Image = "Fake Image",
//    Price = 20
//};

//var json = JsonSerializer.Serialize(newProduct);
//var content = new StringContent(json, Encoding.UTF8, "application/json");

//var response = await httpClient.PostAsync("products", content);

Console.WriteLine(await response.Content.ReadAsStringAsync());