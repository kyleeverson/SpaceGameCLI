using System;

namespace SpaceGame
{

	class Manager {
		public void processInput() {
			while (true) {
				Console.Write("Command? ");
				string input = Console.ReadLine();
				if (input == "Y") {
					break;
				}
			}
            Console.WriteLine("Hello World!");
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
