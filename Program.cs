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
			bool done = false;
			while (!done) {
				Console.Write("\nCommand? ");
				string input = Console.ReadLine();
				string processLine = input.ToLower();

				switch (input) {
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

					default:
						Console.WriteLine("Unknown command");
						break;

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
