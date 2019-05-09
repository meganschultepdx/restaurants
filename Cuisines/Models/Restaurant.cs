using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;

namespace Cuisines.Models
{
  public class Restaurant
  {
    public string RestaurantName;
    public int Id;
    public int CategoryId;

    public Restaurant (string restaurantName, int categoryId, int id = 0)
    {
      RestaurantName = restaurantName;
      CategoryId = categoryId;
      Id = id;
    }
  }
}
