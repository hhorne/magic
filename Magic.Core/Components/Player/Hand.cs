using System.Collections.Generic;
using Magic.Core.CES;

namespace Magic.Core.Components.Player
{
	public class Hand : Component
	{
		public const int DefaultMaxSize = 7;

		public List<ICard> Cards { get; set; }
		public int MaxSize { get; private set; }

		public Hand()
		{
			this.Cards = new List<ICard>();
			this.MaxSize = Hand.DefaultMaxSize;
		}
	}
}
