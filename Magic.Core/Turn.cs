using System.Collections.Generic;
using System.Linq;
using Magic.Core.Components.Player;
using Magic.Core.SpellTypes;
using Magic.Core.TurnPhases;

namespace Magic.Core
{
	public class Turn
	{
		public IEnumerable<Phase> GetPhases()
		{
			yield return new Beginning();
			yield return new MainPreCombat();
			yield return new Combat();
			yield return new MainPostCombat();
			yield return new Ending();
		}
	}
}