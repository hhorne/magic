using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magic.Core.Components.Player;
using Magic.Core.SpellTypes;
using Xunit;

namespace Magic.Core.Tests
{
	public class Lands
	{
		private readonly Player player;

		public Lands()
		{
			this.player = new Player("Cool dude");
		}

		[Fact]
		public void IslanAddsBToManaPool()
		{
			const string abilityDescription = "Tap to add B to your mana pool.";
			var island = new Land { Name = "Island" };
			island.AddAbility(
				abilityDescription,
				(controller, permanent) => {
					permanent.Tap();
					controller.GetComponent<ManaPool>().Mana.Add(ManaColors.Blue);
				}
			);

			island.ActivateAbility(abilityDescription, player);

			var blueMana = player.GetComponent<ManaPool>().Mana.Count(p => p == ManaColors.Blue);
			Assert.Equal(1, blueMana);
		}
	}
}
