using System;
using System.Collections.Generic;
using System.Linq;
using Magic.Core.CES;

namespace Magic.Core
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
