using System;
using System.Collections.Generic;

namespace SpaceGame {
	public class Universe {
		SpaceQuadrant quadrant;

		public BaseShip m_MyShip { get; set; }

		private StarList m_StarList;

		private EnemyList m_EnemyList;

        public Universe() {
			quadrant = new SpaceQuadrant();
			
			m_MyShip = new BaseShip();
			m_MyShip.RandomLocation();

			m_StarList = new StarList();
			m_StarList.BuildStarList(5);

			m_EnemyList = new EnemyList();
			m_EnemyList.BuildEnemyList(5);
		}

		public string BuildOutputString() {
			string retValue = "  | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 |\n";
			retValue += "--|---|---|---|---|---|---|---|---|\n";

			for (int i = 0; i < 8; i++) {
				retValue += string.Format("{0} |", Convert.ToChar(i+65));
				for (int j = 0; j < 8; j++) {
					int item = 0;
					char chItem = ' ';
					if (m_MyShip.IsMyShipLocation(j, i) == true) {
						item = 1;
					}
					if (m_StarList.IsStar(j, i) == true) {
						item = 2;
					}
					if (m_EnemyList.IsShip(j, i) == true) {
						item = 3;
					}
					switch (item) {
						case 0:
							chItem = '-';
							break;
						case 1:
							chItem = 'S';
							break;
						case 2:
							chItem = '*';
							break;
						case 3:
							chItem = 'E';
							break;
					}
					retValue += string.Format(" {0} |", chItem);
				}
				retValue += "\n";
			}

			return retValue;
		}
	}
}
