using System.Collections.Generic;
using Magic.Core.SpellTypes;

namespace Magic.Core
{
	public interface IPlayer
	{
		bool Lost { get; }
		int LifeTotal { get; set; }
		List<Permanent> Board { get; set; }
		List<ICard> Hand { get; set; }
		Stack<ICard> Library { get; set; }
		List<ICard> Graveyard { get; set; }
		void TakeTurn(Game game);
	}
}