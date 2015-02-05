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
			ISpell spell = new Artifact();
			Assert.True(spell.IsPermanent);
		}

		[Fact]
		public void InstantIsNotAPermanent()
		{
			var spell = new Instant();
			Assert.False(spell.IsPermanent);
		}
	}
}
