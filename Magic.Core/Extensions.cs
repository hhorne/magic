using System;
using System.Collections.Generic;
using System.Linq;

public static class Extensions
{
	public static void ForEach<T>(this IEnumerable<T> enumeration, Action<T> action)
	{
		foreach(T item in enumeration)
		{
			action(item);
		}
	}

	public static bool None<TSource>(this IEnumerable<TSource> source)
	{
		return !source.Any();
	}

	public static IEnumerable<T> CycleForever<T>(this IEnumerable<T> loop)
	{
		while(true)
		{
			foreach (var ret in loop)
				yield return ret;
		}
	}
}