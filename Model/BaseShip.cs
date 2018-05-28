
namespace SpaceGame {
	class BaseShip {
		public double Shields { get; set; }
		public double Damage { get; set; }
		public Location Location { get; set; }

		public BaseShip() {
			Shields = 100;
			Damage = 100;
			Location = new Location{ X = -1, Y = -1 };
		}

	}
}