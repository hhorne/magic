using Magic.Core.CES;

namespace Magic.Core.Components.Player
{
	public class Life : Component
	{
		public int Total { get; set; }

		public Life()
		{
			this.Total = 20;
		}
	}
}
