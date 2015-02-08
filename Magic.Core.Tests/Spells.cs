using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magic.Core.SpellTypes;
using Xunit;

namespace Magic.Core.Tests
{
	public class Spells
	{
		[Fact]
		public void ArtifactIsAPermanent()
		{
			ICard card = new Artifact();
			Assert.True(card.IsPermanent);
		}

		[Fact]
		public void InstantIsNotAPermanent()
		{
			ICard card = new Instant();
			Assert.False(card.IsPermanent);
		}
	}
}
