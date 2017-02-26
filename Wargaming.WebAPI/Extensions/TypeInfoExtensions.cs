using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Wargaming.WebAPI.Extensions
{
	public static class TypeInfoExtensions
	{
		public static IEnumerable<MemberInfo> GetMembers(this TypeInfo type)
		{
			var properties = type.DeclaredProperties.Cast<MemberInfo>().Concat(type.DeclaredFields.Cast<MemberInfo>());
			if (type.BaseType != typeof(object))
			{
				properties = properties.Concat(type.BaseType.GetTypeInfo().GetMembers());
			}

			return properties;
		}

		public static object GetValue(this MemberInfo member, object obj)
		{
			if (obj == null || member == null)
			{
				return default(object);
			}

			var field = member as FieldInfo;
			if (field != null)
			{
				return field.GetValue(obj);
			}

			var property = member as PropertyInfo;
			if (property != null)
			{
				return property.GetValue(obj);
			}

			return default(object);
		}
	}
}