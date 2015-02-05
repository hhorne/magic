using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Magic.Core.SpellTypes;

namespace Magic.Core
{
	public abstract class Spell : ISpell
	{
		public Guid ID { get; private set; }
		public string Name { get; set; }
		private readonly Type BaseType;

		public Spell()
		{
			this.ID = Guid.NewGuid();
		}

		public bool IsPermanent
		{
			get
			{
				var baseType = this.GetType().GetTypeInfo().BaseType;
				if (baseType == typeof(Permanent))
					return true;

				return false;
			}
		}
	}
}
