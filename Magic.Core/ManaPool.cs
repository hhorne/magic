using System;
using System.Collections.Generic;
using System.Linq;

namespace Magic.Core
{
	public class ManaPool
	{
		public List<ManaColors> Mana { get; set; }

		public ManaPool()
		{
			this.Mana = new List<ManaColors>();
		}
	}
}
