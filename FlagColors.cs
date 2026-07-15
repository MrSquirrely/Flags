using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Flags;

public static class FlagColors {
	public static readonly Dictionary<FlagColor, string[]> Colors = new()
	{
		{ FlagColor.Rainbow, ["hsl(0deg 0% 18%)", "hsl(30deg 60% 30%)", "hsl(0deg 90% 55%)", "hsl(30deg 95% 65%)", "hsl(55deg 90% 65%)", "hsl(100deg 65% 45%)", "hsl(220deg 80% 55%)", "hsl(265deg 80% 50%)"] },
		{ FlagColor.RainbowOriginal, ["hsl(0deg 90% 55%)", "hsl(30deg 95% 65%)", "hsl(55deg 90% 65%)", "hsl(100deg 65% 45%)", "hsl(220deg 80% 55%)", "hsl(265deg 80% 50%)"] },
		{ FlagColor.Transgender, ["hsl(200deg 85% 70%)", "hsl(350deg 85% 85%)", "hsl(0deg 0% 100%)", "hsl(350deg 85% 85%)", "hsl(200deg 85% 70%)"] },
		{ FlagColor.Pansexual, ["hsl(331deg 100% 55%)", "hsl(50deg 100% 50%)", "hsl(200deg 100% 55%)"] },
		{ FlagColor.Bisexual, ["hsl(326deg 74% 43%)", "hsl(278deg 42% 46%)", "hsl(214deg 65% 36%)"] },
		{ FlagColor.NonBinary, ["hsl(53deg 89% 55%)", "hsl(0deg 0% 100%)", "hsl(283deg 42% 46%)", "hsl(0deg 0% 18%)"] },
		{ FlagColor.Lesbian, ["hsl(17deg 86% 45%)", "hsl(24deg 87% 62%)", "hsl(0deg 0% 100%)", "hsl(325deg 51% 65%)", "hsl(330deg 50% 41%)"] }
	};
}

public enum FlagColor {
	[Display(Name = "Rainbow")]
	Rainbow,
	[Display(Name = "Rainbow")]
    RainbowOriginal,
	[Display(Name = "Transgender")]
	Transgender,
	[Display(Name = "Pansexual")]
	Pansexual,
	[Display(Name = "Bisexual")]
	Bisexual,
	[Display(Name = "Non-Binary")]
	NonBinary,
	[Display(Name = "Lesbian")]
	Lesbian
}

public static class EnumExtensions {
	public static string GetDisplayName(this Enum enumValue) {
		Type type = enumValue.GetType();
		string? name = Enum.GetName(type, enumValue);

		if (name == null) {
			return enumValue.ToString();
		}

		FieldInfo? field = type.GetField(name);
		if (field == null) {
			return enumValue.ToString();
		}

		if (Attribute.GetCustomAttribute(field, typeof(DisplayAttribute)) is DisplayAttribute attribute) {
			return attribute.Name ?? name;
		}
		return enumValue.ToString();
	}
}
