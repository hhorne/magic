using System;
using System.Collections.Generic;
using System.Linq;
using Magic.Core.CES;

namespace Magic.Core
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
