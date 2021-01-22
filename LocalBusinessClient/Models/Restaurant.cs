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
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Restaurant> restaurantList = JsonConvert.DeserializeObject<List<Restaurant>>(jsonResponse.ToString());

      return restaurantList;
    }

    public static Restaurant GetDetails(int id)
    {
      var apiCallTask = ApiHelper.Get(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Restaurant restaurant = JsonConvert.DeserializeObject<Restaurant>(jsonResponse.ToString());

      return restaurant;
    }

    public static void Post(Restaurant restaurant)
    {
      string jsonRestaurant = JsonConvert.SerializeObject(restaurant);
      var apiCallTask = ApiHelper.Post(jsonRestaurant);
    }

    public static void Put(Restaurant restaurant)
    {
      string jsonRestaurant = JsonConvert.SerializeObject(restaurant);
      var apiCallTask = ApiHelper.Put(restaurant.RestaurantId, jsonRestaurant);
    }

    public static void Delete(int id)
    {
      var apiCallTask = ApiHelper.Delete(id);
    }
  }
}