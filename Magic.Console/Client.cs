using System;
using System.Collections.Generic;
using Magic.Core;

namespace Magic.Console
{
	public class Client
	{
		readonly Dictionary<ConsoleKey, Action> menuOptions = new Dictionary<ConsoleKey, Action>();

		public Client()
		{
			this.InitializeMenu();
		}

		private void LogMessage(string format = "", params object[] arg)
		{
			System.Console.WriteLine(format, arg);
		}

		private ConsoleKey ReadKey(bool intercept = false)
		{
			return System.Console.ReadKey(intercept).Key;
		}

		private void InitializeMenu()
		{
			this.menuOptions.Add(ConsoleKey.Enter, Start);
			this.menuOptions.Add(ConsoleKey.Escape, () => LogMessage("Exiting..."));
		}

		public void PrintGreeting()
		{
			LogMessage("Magic Cards!");
			LogMessage();
			LogMessage("Press [Enter] to play or [Esc] to quit.");
		}

		public Action PromptUserToPlay()
		{
			var keyPress = ReadKey();
			while (menuOptions.ContainsKey(keyPress) == false)
			{
				keyPress = ReadKey();
			}

			var action = menuOptions[keyPress];
			return action;
		}

		public void Start()
		{
			var game = new Game();
			game.Players.AddRange(new[]{
				new ConsolePlayer("Cool Dude"),
				new AiPlayer("AI Cheater BS")
			});

			foreach (var gs in game.Play())
			{
				game.TakeTurn(gs.ActivePlayer);

				while (ReadKey() != ConsoleKey.Enter) { }
			}

			LogMessage("GAME OVER");
			LogMessage("Thanks for playing");
		}
	}
}
