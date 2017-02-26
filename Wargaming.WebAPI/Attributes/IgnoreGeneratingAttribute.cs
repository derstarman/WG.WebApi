using System;

namespace Wargaming.WebAPI
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
	public class IgnoreGeneratingAttribute : Attribute
	{
	}
}