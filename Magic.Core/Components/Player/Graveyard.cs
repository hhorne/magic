using System.Collections.Generic;
using Magic.Core.CES;

namespace Magic.Core.Components.Player
{
	public class Graveyard : Component
	{
		public List<ICard> Cards { get; set; }

		public Graveyard()
		{
			this.Cards = new List<ICard>();
		}
	}
}
