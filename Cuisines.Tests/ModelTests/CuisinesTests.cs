using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cuisines.Models;
using System.Collections.Generic;
using System;

namespace Cuisines.Tests
{
  [TestClass]
  public class CuisineTest: IDisposable
  {
    public CuisineTest()
    {
      DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=restaurants_test;";
    }

    public void Dispose()
    {
      Cuisine.ClearAll();
      // Restaurant.ClearAll();
    }

    [TestMethod]
    public void CuisineConstructor_CreatesInstanceOfCuisine_Cuisine()
    {
      Cuisine newCuisine = new Cuisine("test cuisine");
      Assert.AreEqual(typeof(Cuisine), newCuisine.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Test Cuisine";
      Cuisine newCuisine = new Cuisine(name);

      //Act
      string result = newCuisine.Name;

      //Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllCuisineObjects_CuisineList()
    {
      //Arrange
      string name01 = "Thai";
      string name02 = "Mexican";
      Cuisine newCuisine1 = new Cuisine(name01);
      newCuisine1.Save();
      Cuisine newCuisine2 = new Cuisine(name02);
      newCuisine2.Save();
      List<Cuisine> newList = new List<Cuisine> { newCuisine1, newCuisine2 };

      //Act
      List<Cuisine> result = Cuisine.GetAll();
      Console.WriteLine(newList);
      Console.WriteLine(result);

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}
