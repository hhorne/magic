using System;
using System.Collections.Generic;
using System.Linq;

namespace Magic.Core.CES
{
	public class Entity
	{
		public string Name { get; private set; }
		private readonly List<Component> components;

		public Entity(string name, params Component[] components)
		{
			Name = name;
			this.components = new List<Component>(components);
		}

		protected void AddComponent(Component component)
		{
			components.Add(component);
		}

		protected void AddComponents(params Component[] components)
		{
			this.components.AddRange(components);
		}

		public T GetComponent<T>()
		{
			return components.OfType<T>().FirstOrDefault();
		}

		public IEnumerable<T> GetComponents<T>()
		{
			return components.OfType<T>();
		}
	}
}
