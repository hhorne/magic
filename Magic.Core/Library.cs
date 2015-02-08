using System;
using System.Collections.Generic;
using System.Linq;
using Magic.Core.CES;

namespace Magic.Core
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
