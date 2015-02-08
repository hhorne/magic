using System.Collections.Generic;
using System.Linq;
using Magic.Core.Components.Player;
using Magic.Core.SpellTypes;

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
					new Step {
						Name = "Untap",
						Action = player =>
							player
								.GetComponent<Board>()
								.Cards
								.OfType<Permanent>()
								.ForEach(card => card.Untap())
					},
					new Step { Name = "Upkeep" },
					new Step {
						Name = "Draw",
						Action = player =>
							player
								.GetComponent<Hand>()
								.Cards
								.Add(
									player
										.GetComponent<Library>()
										.Cards
										.Pop()
								)
					}
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