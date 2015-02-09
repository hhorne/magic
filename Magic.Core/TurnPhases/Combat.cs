using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic.Core.TurnPhases
{
	class Combat : Phase
	{
		public Combat()
		{
			this.Name = "Combat";
			this.Steps = new[] {
				new Step {Name = "Begining"},
				new Step {Name = "Declare Attackers"},
				new Step {Name = "Declare Blockers"},
				new Step {Name = "Combat Damage"},
				new Step {Name = "End"},
			};
		}
	}
}
