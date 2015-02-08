using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic.Core.SpellTypes
{
	public class Permanent : Spell
	{
		public Player Controller { get; set; }
		public bool Tapped { get; private set; }

		private Dictionary<string, Action<Player, Permanent>> Abilities { get; set; }

		public Permanent()
		{
			this.Abilities = new Dictionary<string, Action<Player, Permanent>>();
		}

		public virtual void Tap()
		{
			this.Tapped = true;
		}

		public void Untap()
		{
			this.Tapped = false;
		}

		public void AddAbility(string name, Action<Player, Permanent> ability)
		{
			this.Abilities.Add(name, ability);
		}

		public void ActivateAbility(string name, Player player)
		{
			var ability = this.Abilities[name];
			ability(player, this);
		}

		public string[] GetAbilities()
		{
			return Abilities.Keys.ToArray();
		}

		public virtual void EntersPlay()
		{
			
		}

		public virtual void LeavesPlay()
		{
			
		}
	}
}
