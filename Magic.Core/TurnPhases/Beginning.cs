using System.Linq;
using Magic.Core.Components.Player;
using Magic.Core.SpellTypes;

namespace Magic.Core.TurnPhases
{
	public class Beginning : Phase
	{
		public Beginning()
		{
			this.Name = "Beginning";
			this.Steps = new[]
			{
				new Step
				{
					Name = "Untap",
					Action = player =>
						player
							.GetComponent<Board>()
							.Cards
							.OfType<Permanent>()
							.ForEach(card => card.Untap())
				},
				new Step {Name = "Upkeep"},
				new Step
				{
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
			};
		}
	}
}