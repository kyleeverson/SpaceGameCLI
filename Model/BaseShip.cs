
using System;

namespace SpaceGame {
	public class BaseShip : Location {
		public double Shields { get; set; }
		public double Damage { get; set; }
	
		public BaseShip() {
			Shields = 100;
			Damage = 100;
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