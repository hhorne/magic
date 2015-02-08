using System;
using System.Collections.Generic;
using Magic.Core;

namespace Magic.Console
{
	public class Program
	{
		static void Main(string[] args)
		{
			var game = new Client();
			game.PrintGreeting();

			var selection = game.PromptUserToPlay();
			selection();
		}

	}
}
