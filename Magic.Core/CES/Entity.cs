using System;
using System.Collections.Generic;
using System.Linq;

namespace Magic.Core.CES
{
	public class Entity
	{
		public string Name { get; private set; }
		List<Component> Components;

		public Entity(string name, params Component[] components)
		{
			Name = name;
			Components = new List<Component>(components);
		}

		public T GetComponent<T>()
		{
			return Components.OfType<T>().FirstOrDefault();
		}

		public IEnumerable<T> GetComponents<T>()
		{
			return Components.OfType<T>();
		}
	}
}
