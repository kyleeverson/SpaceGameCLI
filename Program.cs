using System;

namespace SpaceGame
{

	class Manager {

		Universe universe;

		public Manager() {
			universe = new Universe();
		}

		public void processInput() {
			while (true) {
				string universeMap = universe.BuildOutputString();
				Console.WriteLine(universeMap);
				
				Console.Write("Command? ");
				string input = Console.ReadLine();
				string processLine = input.ToLower();
				if (input == "exit") {
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
			manager.processInput();
        }
    }
}
