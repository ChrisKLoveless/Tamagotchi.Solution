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
      Tama tama = new Tama();
    Assert.AreEqual(typeof(Tama), tama.GetType());
    }
  }
}