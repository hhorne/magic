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

		public override void EnterPhase(Phase phase)
		{
			LogMessage("Player: {0} entering Turn Phase {1}", this.Name, phase.Name);
			base.EnterPhase(phase);
			LogMessage("Player: {0} ending Turn Phase {1}", this.Name, phase.Name);
		}

		private void LogMessage(string format, params object[] arg)
		{
			System.Console.WriteLine(format, arg);
		}
	}
}
