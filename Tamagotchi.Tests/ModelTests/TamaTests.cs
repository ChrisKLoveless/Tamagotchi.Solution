using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Tamagotchi.Models;
using System;

namespace Tamagotchi.Tests
{
  [TestClass]
  public class TamaTests
  {
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
  }
}