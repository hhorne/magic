using System.Collections.Generic;
using Magic.Core.CES;

namespace Magic.Core.Components.Player
{
	public class Hand : Component
	{
		public List<ICard> Cards { get; set; }

		public Hand()
		{
			this.Cards = new List<ICard>();
		}
	}
}
