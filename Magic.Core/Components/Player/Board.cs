using System.Collections.Generic;
using Magic.Core.CES;

namespace Magic.Core.Components.Player
{
	public class Board : Component
	{
		public List<ICard> Cards { get; set; }

		public Board()
		{
			this.Cards = new List<ICard>();
		}
	}
}
