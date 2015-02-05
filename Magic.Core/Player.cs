using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magic.Core.SpellTypes;

namespace Magic.Core
{
	public class Player : IPlayer
	{
		private Guid id = Guid.NewGuid();
		private bool lost = false;
		public string Name { get; set; }
		public int LifeTotal { get; set; }
		public Game Game { get; set; }
		public List<Permanent> Board { get; set; }
		public List<ICard> Hand { get; set; }
		public Stack<ICard> Library { get; set; }
		public List<ICard> Graveyard { get; set; }
		public List<ManaColors> ManaPool { get; set; }

		public bool Lost
		{
			get
			{
				var notDead = this.LifeTotal > 0;
				var cardsLeft = this.Library.Any();

				return lost && notDead && cardsLeft;
			}
			protected set
			{
				lost = value;
			}
		}

		public Player()
		{
			this.LifeTotal = 20;
			this.Board = new List<Permanent>();
			this.Hand = new List<ICard>();
			this.Library = new Stack<ICard>();
			this.Graveyard = new List<ICard>();
			this.ManaPool = new List<ManaColors>();
		}

		public virtual void TakeTurn(Game game)
		{
			this.HandleUpkeep(game);
			this.Untap(game);
			this.DrawCard(game);
		}

		protected virtual void HandleUpkeep(Game game)
		{
			
		}

		protected virtual void Untap(Game game)
		{
			// Cards to keep in mind that can affect the Untap Step:
			// Stasis
			// Winter Orb
			foreach (var p in Board)
			{
				p.Untap();
			}
		}

		protected virtual void DrawCard(Game game)
		{
			// This is a game loss condition.
			if (this.Library.None())
			{
				return;
			}

			// Account for cards like Howling Mine that add additional cards to the draw step
			// Necropotence causes the player to skip their draw step
			this.Hand.Add(this.Library.Pop());
		}
	}
}
