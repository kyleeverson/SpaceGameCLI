using System;

namespace SpaceGame
{

	class Manager {

		Universe universe;

		public Manager() {
			universe = new Universe();
		}

		public void DisplayHelp() {
			Console.WriteLine("srs - Short range scan");
			Console.WriteLine("help - Display this help message.");
			Console.WriteLine("exit - Exit the game");
		}

		public void DisplayMap() {
			string universeMap = universe.BuildOutputString();
			Console.Write(universeMap);
		}

		public void ProcessInput() {
			DisplayMap();
			
			bool done = false;
			while (!done) {
				Console.Write("\nCommand? ");
				string input = Console.ReadLine();
				string processLine = "";

				string[] fullcommand = input.Split(' ');
				if (fullcommand.Length > 0) {
					processLine = fullcommand[0];
				}

				bool validcommand = true;

				switch (processLine) {
					case "srs":
						DisplayMap();
						break;

					case "help":
					case "":
						DisplayHelp();
						break;

					case "exit":
						done = true;
						break;

					case "move":
						if (fullcommand.Length == 3 && fullcommand[1].Length == 1 && fullcommand[2].Length == 1) {
							int row = Convert.ToInt32(fullcommand[1].ToUpper()[0] - 'A');
							int col = Convert.ToInt32(fullcommand[2].ToUpper()[0] - '1');
							Console.WriteLine("{0} {1}", row, col);
							if (row >= 0 && row < 8 && col >= 0 && col < 8) {
								universe.m_MyShip.X = col;
								universe.m_MyShip.Y = row;
							}
							DisplayMap();
						} else {
							validcommand = false;
						}
						break;

					default:
						validcommand = false;
						break;
				}
				if (validcommand == false) {
					Console.WriteLine("Unknown command");
				}
			}
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			Manager manager = new Manager();
			manager.ProcessInput();
        }
    }
}
