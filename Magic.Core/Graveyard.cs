using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magic.Core.CES;

namespace Magic.Core
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
