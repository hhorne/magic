using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magic.Core.CES;
using Magic.Core.Components.Player;
using Magic.Core.SpellTypes;

namespace Magic.Core
{
	public class Player : Entity
	{
		private Guid id = Guid.NewGuid();
		private bool lost = false;

		public Game Game { get; set; }

		public bool Lost
		{
			get
			{
				var notDead = this.GetComponent<Life>().Total > 0;
				var cardsLeft = this.GetComponent<Library>().Cards.Any();

				return lost && notDead && cardsLeft;
			}
			protected set
			{
				lost = value;
			}
		}

		public Player(string name)
			: base(name,
				new Library(),
				new Hand(),
				new Board(),
				new Graveyard(),
				new ManaPool(),
				new Life())
		{
		}

		public Player(string name, params Component[] components) 
			: base(name, components)
		{
		}

		public virtual void EnterPhase(Phase phase)
		{
			phase.Execute(this);
		}
	}
}
