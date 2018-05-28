
using System;

namespace SpaceGame {
	class BaseShip : Location {
		public double Shields { get; set; }
		public double Damage { get; set; }
	
		public BaseShip() {
			Shields = 100;
			Damage = 100;
		}

		internal void RandomLocation()
		{
			Random rnd = new Random();
			X = rnd.Next(0, 8);
			Y = rnd.Next(0, 8);
		}

		public bool IsMyShipLocation(int x, int y) {
			bool flag = false;

			if (x == X && y == Y) {
				flag = true;
			}

			return flag;
		}
	}
}