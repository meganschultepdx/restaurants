using System;
using MySql.Data.MySqlClient;
using Cuisines;

namespace Cuisines.Models
{
  public class DB
  {
    public static MySqlConnection Connection()
    {
      MySqlConnection conn = new MySqlConnection(DBConfiguration.ConnectionString);
      return conn;
    }
  }
}
