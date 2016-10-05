using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace UnitTests
{
	[TestFixture ()]
	public class ShipTest
	{
		[Test()]
		public void newShipAdded()
		{
			Ship s = new Ship (ShipName.Tug);
			Assert.AreEqual ("Tug", s.Name);
		}

		[Test()]
		public void sizeOfShip()
		{
			Ship s = new Ship (ShipName.Tug);
			Assert.AreEqual(1, s.Size);
		}

		[Test()]
		public void Score()
		{
			Ship s = new Ship (ShipName.Tug);
			BattleShipsGame bs = new BattleShipsGame ();
			Player p = new Player (bs);
			Tile t = new Tile (0,0,s);
			s.AddTile (t);
			s.Hit ();
			int expect = 0;
			int actual = p.Score;

			Assert.AreEqual(expect, actual);
		}
	}
}

