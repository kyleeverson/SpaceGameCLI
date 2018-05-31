

using System.Collections.Generic;

namespace SpaceGame {

    class StarList : List<Location> {

        public void BuildStarList() {
			for (int i = 0; i < 5; i++) {
				Location starLocation = new Location();
				starLocation.RandomLocation();
                Add(starLocation);
			}
        }
        
    }
}