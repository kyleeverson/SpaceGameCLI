

using System;
using System.Collections.Generic;

namespace SpaceGame {
	public class Universe {
		SpaceQuadrant quadrant;

		public BaseShip m_MyShip { get; set; }
		public List<Location> m_StarList { get; set; }

		public Universe() {
			quadrant = new SpaceQuadrant();
			m_MyShip = new BaseShip();
			m_MyShip.RandomLocation();

			for (int i = 0; i < 5; i++) {
				Location starLocation = new Location();
				starLocation.RandomLocation();
				m_StarList.Add(starLocation);
			}
			
		}

		public string BuildOutputString() {
			string retValue = "  : 1 : 2 : 3 : 4 : 5 : 6 : 7 : 8 :\n";
			retValue += "--:---:---:---:---:---:---:---:---:\n";

			for (int i = 0; i < 8; i++) {
				retValue += string.Format("{0} :", Convert.ToChar(i+65));
				for (int j = 0; j < 8; j++) {
					int item = 0;
					char chItem = ' ';
					if (m_MyShip.IsMyShipLocation(j, i) == true) {
						item = 1;
					}
					switch (item) {
						case 0:
							chItem = '-';
							break;
						case 1:
							chItem = 'S';
							break;
					}
					retValue += string.Format(" {0} :", chItem);
				}
				retValue += "\n";
			}

			return retValue;

		}

	}
}
