

namespace SpaceGame {
	public class Universe {
		SpaceQuadrant quadrant;

		public Universe() {
			quadrant = new SpaceQuadrant();
		}

		public string BuildOutputString() {
			string retValue = "";

			retValue = "UniverseMap\n";

			return retValue;

		}

	}
}
