using Magic.Core;
using Magic.Core.CES;

namespace Magic.Console
{
	public class ConsolePlayer : Player
	{
		public ConsolePlayer(string name) : base(name)
		{
		}

		public ConsolePlayer(string name, params Component[] components) : base(name, components)
		{
		}
	}
}
