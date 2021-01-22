using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LocalBusinessClient.Models
{
  public class Shop
  {
    public int ShopId { get; set; }
    public string Name { get; set; }
    public string StreetAddress { get; set; }
    public string KeyBusiness { get; set; }

    public static List<Shop> GetShops()
    {
      var apiCallTask = ShopApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Shop> shopList = JsonConvert.DeserializeObject<List<Shop>>(jsonResponse.ToString());

      return shopList;
    }

    public static Shop GetDetails(int id)
    {
      var apiCallTask = ShopApiHelper.Get(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Shop shop = JsonConvert.DeserializeObject<Shop>(jsonResponse.ToString());

      return shop;
    }

    public static void Post(Shop shop)
    {
      string jsonShop = JsonConvert.SerializeObject(shop);
      var apiCallTask = ShopApiHelper.Post(jsonShop);
    }

    public static void Put(Shop shop)
    {
      string jsonShop = JsonConvert.SerializeObject(shop);
      var apiCallTask = ShopApiHelper.Put(shop.ShopId, jsonShop);
    }

    public static void Delete(int id)
    {
      var apiCallTask = ShopApiHelper.Delete(id);
    }
  }
}