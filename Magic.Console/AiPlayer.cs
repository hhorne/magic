using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magic.Core;
using Magic.Core.CES;

namespace Magic
{
	public class AiPlayer : ConsolePlayer
	{
		public AiPlayer(string name, params Component[] components) : base(name, components)
		{
		}
	}
}
