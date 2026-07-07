namespace Flags;

public static class FlagColors {
	public static readonly Dictionary<string, string[]> Colors = new()
	{
		{ "rainbow", ["hsl(0deg 0% 18%)", "hsl(30deg 60% 30%)", "hsl(0deg 90% 55%)", "hsl(30deg 95% 65%)", "hsl(55deg 90% 65%)", "hsl(100deg 65% 45%)", "hsl(220deg 80% 55%)", "hsl(265deg 80% 50%)"] },
		{ "rainbow-original", ["hsl(0deg 90% 55%)", "hsl(30deg 95% 65%)", "hsl(55deg 90% 65%)", "hsl(100deg 65% 45%)", "hsl(220deg 80% 55%)", "hsl(265deg 80% 50%)"] },
		{ "trans", ["hsl(200deg 85% 70%)", "hsl(350deg 85% 85%)", "hsl(0deg 0% 100%)", "hsl(350deg 85% 85%)", "hsl(200deg 85% 70%)"] },
		{ "pan", ["hsl(331deg 100% 55%)", "hsl(50deg 100% 50%)", "hsl(200deg 100% 55%)"] },
		// New additions
		{ "bi", ["hsl(326deg 74% 43%)", "hsl(278deg 42% 46%)", "hsl(214deg 65% 36%)"] },
		{ "nonbinary", ["hsl(53deg 89% 55%)", "hsl(0deg 0% 100%)", "hsl(283deg 42% 46%)", "hsl(0deg 0% 18%)"] },
		{ "lesbian", ["hsl(17deg 86% 45%)", "hsl(24deg 87% 62%)", "hsl(0deg 0% 100%)", "hsl(325deg 51% 65%)", "hsl(330deg 50% 41%)"] }
	};
}
