using System;
using System.Collections.Generic;
using System.Linq;
using Magic.Core.CES;

namespace Magic.Core
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
