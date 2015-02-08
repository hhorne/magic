using System;
using System.Collections.Generic;
using Magic.Core.CES;

namespace Magic.Core
{
	public class Phase : CES.System
	{
		public string Name { get; set; }
		public IEnumerable<Step> Steps { get; set; }

		public Phase()
		{
			this.Steps = new Step[0];
		}

		public void Execute(Entity entity)
		{
			this.Steps.ForEach(step => this.RunSystem(entity, step.Action));
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
