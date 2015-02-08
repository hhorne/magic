using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magic.Core.CES;
using Magic.Core.SpellTypes;

namespace Magic.Core
{
	public class Player : Component
	{
		private Guid id = Guid.NewGuid();
		private bool lost = false;

		public string Name { get; set; }
		public int LifeTotal { get; set; }
		public Game Game { get; set; }
		public Board Board { get; set; }
		public Hand Hand { get; set; }
		public Library Library { get; set; }
		public Graveyard Graveyard { get; set; }
		public ManaPool ManaPool { get; set; }

		public bool Lost
		{
			get
			{
				var notDead = this.LifeTotal > 0;
				var cardsLeft = this.Library.Cards.Any();

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
		}
	}
}
