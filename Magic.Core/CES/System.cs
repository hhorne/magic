using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic.Core.CES
{
	public class System
	{
		public void RunSystem(Entity entity, Action<Entity> act)
		{
			act(entity);
		}
	}
}
