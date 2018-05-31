

using System.Collections.Generic;

namespace SpaceGame {
    class EnemyList : List<BaseShip> {

        public void BuildEnemyList(int size) {
			for (int i = 0; i < size; i++) {
				BaseShip shipLocation = new BaseShip();
				shipLocation.RandomLocation();
                Add(shipLocation);
			}
        }

        public bool IsShip(int x, int y) {
            bool flag = false;
            foreach (Location ship in this) {
                if (ship.X == x && ship.Y == y) {
                    flag = true;
                }
            }

            return flag;
        }
    }
}