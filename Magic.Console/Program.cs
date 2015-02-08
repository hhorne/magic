using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magic.Core;
using Magic.Core.Components.Player;

namespace Magic
{
	public class MagicGame
	{
		readonly Dictionary<ConsoleKey, Action> menuOptions = new Dictionary<ConsoleKey, Action>();

		static void Main(string[] args)
		{
			var game = new MagicGame();
			game.SetupMenuOptions();
			game.PrintGreeting();

			var selection = game.PromptUserToPlay();
			selection();
		}

		private void SetupMenuOptions()
		{
			this.menuOptions.Add(ConsoleKey.Enter, Start);
			this.menuOptions.Add(ConsoleKey.Escape, () => Console.WriteLine("Exiting..."));
		}

		private void Start()
		{
			var game = new Game();
			game.Players.AddRange(new Player[]{
				new ConsolePlayer("Cool Dude",
					new Library(),
					new Hand(),
					new Board(),
					new Graveyard(),
					new ManaPool(),
					new Life()
				),
				new AiPlayer("AI Cheater BS",
					new Library(),
					new Hand(),
					new Board(),
					new Graveyard(),
					new ManaPool(),
					new Life()
				)
			});

			foreach(var gs in game.Play())
			{
				game.TakeTurn(gs.ActivePlayer);
			}

			Console.WriteLine("GAME OVER");
			Console.WriteLine("Thanks for playing");
		}

		private void PrintGreeting()
		{
			Console.WriteLine("Magic Cards!");
			Console.WriteLine();
			Console.WriteLine("Press [Enter] to play or [Esc] to quit.");
		}

		private Action PromptUserToPlay()
		{
			var keyPress = Console.ReadKey().Key;
			while (menuOptions.ContainsKey(keyPress) == false)
			{
				keyPress = Console.ReadKey().Key;
			}

			var action = menuOptions[keyPress];
			return action;
		}

	}
}
