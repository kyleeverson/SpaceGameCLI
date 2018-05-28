

using System;

namespace SpaceGame {
	public class Universe {
		SpaceQuadrant quadrant;

		public Universe() {
			quadrant = new SpaceQuadrant();
		}

		public string BuildOutputString() {
			string retValue = "--:---:---:---:---:---:---:---:---:\n";

			for (int i = 0; i < 8; i++) {
				retValue += string.Format("{0} :", Convert.ToChar(i+65));
				for (int j = 0; j < 8; j++) {
					retValue += " - :";
				}
				retValue += "\n";
			}

			return retValue;

		}

	}
}
