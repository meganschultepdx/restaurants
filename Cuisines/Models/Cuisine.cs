using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Cuisines.Models
{
  public class Cuisine
  {
    private string _name;
    private int _id;
    private List<Restaurant> _restaurants;

    public Cuisine(string cuisineName, int id = 0)
    {
      _name = cuisineName;
      _id = id;
      _restaurants = new List<Restaurant>{};
    }




  }
}
