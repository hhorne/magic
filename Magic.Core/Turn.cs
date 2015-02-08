using System.Collections.Generic;

namespace Magic.Core
{
	public class Turn
	{
		public IEnumerable<Phase> GetPhases()
		{
			yield return new Phase
			{
				Name = "Beginning",
				Steps = new[] {
					new Step { Name = "Untap" },
					new Step { Name = "Upkeep" },
					new Step { Name = "Draw" },
				}
			};
			yield return new Phase { Name = "Main (Pre-Combat)" };
			yield return new Phase
			{
				Name = "Combat",
				Steps = new[] {
					new Step { Name = "Begining" },
					new Step { Name = "Declare Attackers" },
					new Step { Name = "Declare Blockers" },
					new Step { Name = "Combat Damage" },
					new Step { Name = "End" },
				}
			};
			yield return new Phase { Name = "Main (Post-Combat)" };
			yield return new Phase { Name = "Ending" };
		}
	}
}