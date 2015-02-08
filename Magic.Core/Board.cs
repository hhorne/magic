using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic.Core
{
	public class Board
	{
		public List<ICard> Cards { get; set; }

		public Board()
		{
			this.Cards = new List<ICard>();
		}
	}
}
