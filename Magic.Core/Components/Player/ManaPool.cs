using System.Collections.Generic;
using Magic.Core.CES;

namespace Magic.Core.Components.Player
{
	public class ManaPool : Component
	{
		public List<ManaColors> Mana { get; set; }

		public ManaPool()
		{
			this.Mana = new List<ManaColors>();
		}
	}
}
