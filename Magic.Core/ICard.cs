using System;

namespace Magic.Core
{
	public interface ICard
	{
		Guid ID { get; }
		string Name { get; set; }
		bool IsPermanent { get; }
	}
}