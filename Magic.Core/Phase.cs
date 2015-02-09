using System;
using System.Collections.Generic;
using Magic.Core.CES;

namespace Magic.Core
{
	public class Phase
	{
		public string Name { get; set; }
		public IEnumerable<Step> Steps { get; set; }

		public Phase()
		{
			this.Steps = new Step[0];
		}
	}

	public class Step
	{
		public string Name { get; set; }
		public Action<Entity> Action { get; set; }

		public Step()
		{
			Action = entity => { };
		}
	}
}
