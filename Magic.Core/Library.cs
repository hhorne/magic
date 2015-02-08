using System;
using System.Collections.Generic;
using System.Linq;

namespace Magic.Core
{
	public class Library
	{
		public Stack<ICard> Cards { get; set; }

		public Library()
		{
			this.Cards = new Stack<ICard>();
		}
	}
}
