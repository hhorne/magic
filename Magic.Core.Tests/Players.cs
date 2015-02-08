using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magic.Console;
using Magic.Core.Components.Player;
using Xunit;

namespace Magic.Core.Tests
{
	public class Players
	{
		readonly Player player = new Player("Cool Dude");

		[Fact(DisplayName = "Have a Library.")]
		public void HaveLibrary()
		{
			var library = player.GetComponent<Library>();
			Assert.NotNull(library);
		}

		[Fact(DisplayName = "Have a Hand.")]
		public void HaveHand()
		{
			var hand = player.GetComponent<Hand>();
			Assert.NotNull(hand);
		}

		[Fact(DisplayName = "Have a Board.")]
		public void HaveBoard()
		{
			var board = player.GetComponent<Board>();
			Assert.NotNull(board);
		}

		[Fact(DisplayName = "Have a Graveyard.")]
		public void HaveGraveyard()
		{
			var graveyard = player.GetComponent<Graveyard>();
			Assert.NotNull(graveyard);
		}

		[Fact(DisplayName = "Have a Mana Pool.")]
		public void HaveManaPool()
		{
			var manaPool = player.GetComponent<ManaPool>();
			Assert.NotNull(manaPool);
		}

		[Fact(DisplayName = "Have a Life.")]
		public void HaveLife()
		{
			var life = player.GetComponent<Life>();
			Assert.NotNull(life);
		}
	}
}
