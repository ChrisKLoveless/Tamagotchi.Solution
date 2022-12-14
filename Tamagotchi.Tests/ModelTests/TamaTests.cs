using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Tamagotchi.Models;
using System;

namespace Tamagotchi.Tests
{
  [TestClass]
  public class TamaTests : IDisposable
  {
  public void Dispose()
  {
    Tama.ClearAll();
  }
    [TestMethod]
    public void Constructor_CreatesInstance_Tamagotchi()
    {
      Tama tama = new Tama("cow", 1, 1, 1);
    Assert.AreEqual(typeof(Tama), tama.GetType());
    }

    [TestMethod]
    public void Constructor_ReturnName_String()
    {
      Tama tama = new Tama("cow", 1, 1, 1);
      Assert.AreEqual("cow", tama.Name);
    }

    [TestMethod]
    public void Constructor_SetName_String()
    {
      Tama tama = new Tama("cow", 1, 1, 1);
      string newName = "moose";
      tama.Name = newName;
      Assert.AreEqual("moose", tama.Name);
    }

    [TestMethod]
    public void PassTime_SetHunger_Int()
    {
      Tama tama = new Tama("cow", 1, 1, 1);
      tama.PassTime();
      Assert.AreEqual(0, tama.Hunger);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_TamaList()
    {
      List<Tama> newList = new List<Tama> { };

      List<Tama> result = Tama.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsItems_ItemList()
    {
      string nameOne = "dog";
      string nameTwo = "cow";
      Tama newTama1 = new Tama(nameOne,1,1,1);
      Tama newTama2 = new Tama(nameTwo,1,1,1);
      List<Tama> newList = new List<Tama> { newTama1, newTama2 };

      List<Tama> result = Tama.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }
  }
}