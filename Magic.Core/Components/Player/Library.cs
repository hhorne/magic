using System.Collections.Generic;
using Magic.Core.CES;

namespace Magic.Core.Components.Player
{
	public class Library : Component
	{
		public Stack<ICard> Cards { get; set; }

		public Library()
		{
			this.Cards = new Stack<ICard>();
		}
	}
}
