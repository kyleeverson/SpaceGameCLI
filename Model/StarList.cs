

using System.Collections.Generic;

namespace SpaceGame {

    class StarList : List<Location> {

        public void BuildStarList(int size) {
			for (int i = 0; i < size; i++) {
				Location starLocation = new Location();
				starLocation.RandomLocation();
                Add(starLocation);
			}
        }

        public bool IsStar(int x, int y) {
            bool flag = false;
            foreach (Location star in this) {
                if (star.X == x && star.Y == y) {
                    flag = true;
                }
            }

            return flag;
        }
        
    }
}