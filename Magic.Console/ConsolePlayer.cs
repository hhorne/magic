using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magic.Core;
using Magic.Core.SpellTypes;

namespace Magic
{
	public class ConsolePlayer : Player
	{
		public override void TakeTurn(Game game)
		{
			this.LogMessage(game, "[Begin Turn]");

			base.TakeTurn(game);

			this.LogMessage(game, "Press [Enter] to [Pass Turn]");
			
			while (Console.ReadKey().Key != ConsoleKey.Enter) { }

			this.LogMessage(game, "[End Turn]");
		}

		protected override void HandleUpkeep(Game game)
		{
			this.LogMessage(game, "[Begin Upkeep]");

			this.LogMessage(game, "[End Upkeep]");
		}

		protected override void Untap(Game game)
		{
			this.LogMessage(game, "[Begin Untap]");

			base.Untap(game);

			this.LogMessage(game, "[End Untap]");
		}

		protected override void DrawCard(Game game)
		{
			this.LogMessage(game, "[Begin Draw Step]");

			base.DrawCard(game);
			
			this.LogMessage(game, "[End Draw Step]");
		}

		private void LogMessage(Game game, string msg)
		{
			Console.WriteLine("Turn #{0} - Player: {1} {2}", game.TurnNumber, this.Name, msg);
		}
	}
}
