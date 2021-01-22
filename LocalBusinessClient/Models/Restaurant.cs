using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LocalBusinessClient.Models
{
  public class Restaurant
  {
    public int RestaurantId { get; set; }
    public string Name { get; set; }
    public string StreetAddress { get; set; }
    public string KeyBusiness { get; set; }

    public static List<Restaurant> GetRestaurants()
    {
      var apiCallTask = RestaurantApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Restaurant> restaurantList = JsonConvert.DeserializeObject<List<Restaurant>>(jsonResponse.ToString());

      return restaurantList;
    }

    // Attempt to make randomized GET request //
    public static Restaurant GetRandom()
    {
      var apiCallTask = RestaurantApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Restaurant> restaurantList = JsonConvert.DeserializeObject<List<Restaurant>>(jsonResponse.ToString());

      return restaurantList.ElementAt(new Random().Next(0, restaurantList.Count() - 1));
    }

    public static Restaurant GetDetails(int id)
    {
      var apiCallTask = RestaurantApiHelper.Get(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Restaurant restaurant = JsonConvert.DeserializeObject<Restaurant>(jsonResponse.ToString());

      return restaurant;
    }

    public static void Post(Restaurant restaurant)
    {
      string jsonRestaurant = JsonConvert.SerializeObject(restaurant);
      var apiCallTask = RestaurantApiHelper.Post(jsonRestaurant);
    }

    public static void Put(Restaurant restaurant)
    {
      string jsonRestaurant = JsonConvert.SerializeObject(restaurant);
      var apiCallTask = RestaurantApiHelper.Put(restaurant.RestaurantId, jsonRestaurant);
    }

    public static void Delete(int id)
    {
      var apiCallTask = RestaurantApiHelper.Delete(id);
    }
  }
}