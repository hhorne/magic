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
		private void LogMessage(Game game, string msg)
		{
			Console.WriteLine("Turn #{0} - Player: {1} {2}", game.TurnNumber, this.Name, msg);
		}
	}
}
