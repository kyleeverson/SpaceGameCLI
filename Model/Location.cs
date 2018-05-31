
using System;

namespace SpaceGame {
	public class Location {
		public int X { get; set; }
		public int Y { get; set; }

		public Location() {
			X = -1;
			Y = -1;
		}

		public void RandomLocation()
		{
			Random rnd = new Random();
			X = rnd.Next(0, 8);
			Y = rnd.Next(0, 8);
		}

	}
}