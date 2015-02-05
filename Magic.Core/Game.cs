using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magic.Core.SpellTypes;

namespace Magic.Core
{
	public class Game
	{
		public int TurnNumber { get; set; }
		public readonly List<IPlayer> Players = new List<IPlayer>();

		public Game()
		{
			TurnNumber = 1;
		}
	}
}
