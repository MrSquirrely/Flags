using System.Collections.Frozen;
using System.Globalization;

namespace Flags;

public static class FlagCatalog {
    private static readonly FlagDefinition[] Definitions = [
        // Pride
        new(FlagColor.RainbowOriginal, "Rainbow Pride", FlagCategory.Pride, ["hsl(0deg 90% 55%)", "hsl(30deg 95% 65%)", "hsl(55deg 90% 65%)", "hsl(100deg 65% 45%)", "hsl(220deg 80% 55%)", "hsl(265deg 80% 50%)"]),
        new(FlagColor.Rainbow, "Philadelphia Pride", FlagCategory.Pride, ["hsl(0deg 0% 18%)", "hsl(30deg 60% 30%)", "hsl(0deg 90% 55%)", "hsl(30deg 95% 65%)", "hsl(55deg 90% 65%)", "hsl(100deg 65% 45%)", "hsl(220deg 80% 55%)", "hsl(265deg 80% 50%)"]),
        new(FlagColor.GilbertBaker, "Gilbert Baker Pride (1978)", FlagCategory.Pride, ["#FF69B4", "#FF0000", "#FF8E00", "#FFFF00", "#008E00", "#00C0C0", "#400098", "#8E008E"]),
        new(FlagColor.ProgressPride, "Progress Pride", FlagCategory.Pride, ["#E40303", "#FF8C00", "#FFED00", "#008026", "#24408E", "#732982"], "progress-pride"),
        new(FlagColor.IntersexInclusiveProgress, "Intersex-Inclusive Progress Pride", FlagCategory.Pride, ["#E40303", "#FF8C00", "#FFED00", "#008026", "#24408E", "#732982"], "intersex-inclusive-progress"),
        new(FlagColor.Lesbian, "Lesbian", FlagCategory.Pride, ["hsl(17deg 86% 45%)", "hsl(24deg 87% 62%)", "hsl(0deg 0% 100%)", "hsl(325deg 51% 65%)", "hsl(330deg 50% 41%)"]),
        new(FlagColor.Gay, "Gay Men", FlagCategory.Pride, ["#078D70", "#26CEAA", "#98E8C1", "#FFFFFF", "#7BADE2", "#5049CC", "#3D1A78"]),
        // The bisexual flag's stripes are 2:1:2, so pink and blue appear twice
        new(FlagColor.Bisexual, "Bisexual", FlagCategory.Pride, ["#D60270", "#D60270", "#9B4F96", "#0038A8", "#0038A8"]),
        new(FlagColor.Pansexual, "Pansexual", FlagCategory.Pride, ["#FF218C", "#FFD800", "#21B1FF"]),
        new(FlagColor.Polysexual, "Polysexual", FlagCategory.Pride, ["#F714BA", "#01D66A", "#1594F6"]),
        new(FlagColor.Omnisexual, "Omnisexual", FlagCategory.Pride, ["#FF9CCE", "#FF53BF", "#270041", "#6760FE", "#8EA6FF"]),
        new(FlagColor.Asexual, "Asexual", FlagCategory.Pride, ["#000000", "#A3A3A3", "#FFFFFF", "#800080"]),
        new(FlagColor.Demisexual, "Demisexual", FlagCategory.Pride, ["#FFFFFF", "#6E0070", "#D2D2D2"], "demisexual"),
        new(FlagColor.Graysexual, "Graysexual", FlagCategory.Pride, ["#740194", "#AEB1AA", "#FFFFFF", "#AEB1AA", "#740194"]),
        new(FlagColor.Aromantic, "Aromantic", FlagCategory.Pride, ["#3DA542", "#A7D379", "#FFFFFF", "#A9A9A9", "#000000"]),
        new(FlagColor.Demiromantic, "Demiromantic", FlagCategory.Pride, ["#FFFFFF", "#3DA542", "#D2D2D2"], "demiromantic"),
        new(FlagColor.AroAce, "Aroace", FlagCategory.Pride, ["#E28C00", "#ECCD00", "#FFFFFF", "#62AEDC", "#203856"]),
        new(FlagColor.Polyamory, "Polyamory", FlagCategory.Pride, ["#009FE3", "#E50051", "#340C46"], "polyamory"),
        new(FlagColor.Transgender, "Transgender", FlagCategory.Pride, ["hsl(200deg 85% 70%)", "hsl(350deg 85% 85%)", "hsl(0deg 0% 100%)", "hsl(350deg 85% 85%)", "hsl(200deg 85% 70%)"]),
        new(FlagColor.NonBinary, "Non-Binary", FlagCategory.Pride, ["hsl(53deg 89% 55%)", "hsl(0deg 0% 100%)", "hsl(283deg 42% 46%)", "hsl(0deg 0% 18%)"]),
        new(FlagColor.Genderfluid, "Genderfluid", FlagCategory.Pride, ["#FF76A4", "#FFFFFF", "#C011D7", "#000000", "#2F3CBE"]),
        new(FlagColor.Genderqueer, "Genderqueer", FlagCategory.Pride, ["#B57EDC", "#FFFFFF", "#4A8123"]),
        new(FlagColor.Agender, "Agender", FlagCategory.Pride, ["#000000", "#BCC4C7", "#FFFFFF", "#B7F684", "#FFFFFF", "#BCC4C7", "#000000"]),
        new(FlagColor.Bigender, "Bigender", FlagCategory.Pride, ["#C479A2", "#EDA5CD", "#D6C7E8", "#FFFFFF", "#D6C7E8", "#9AC7E8", "#6D82D1"]),
        new(FlagColor.Demigirl, "Demigirl", FlagCategory.Pride, ["#7F7F7F", "#C4C4C4", "#FFAEC9", "#FFFFFF", "#FFAEC9", "#C4C4C4", "#7F7F7F"]),
        new(FlagColor.Demiboy, "Demiboy", FlagCategory.Pride, ["#7F7F7F", "#C4C4C4", "#9AD9EB", "#FFFFFF", "#9AD9EB", "#C4C4C4", "#7F7F7F"]),
        new(FlagColor.Intersex, "Intersex", FlagCategory.Pride, ["#FFD800"], "intersex"),

        // Countries: the ten most populous, drawn on a common 3:2 canvas
        new(FlagColor.India, "India", FlagCategory.Country, ["#FF9933", "#FFFFFF", "#138808"], "india"),
        new(FlagColor.China, "China", FlagCategory.Country, ["#EE1C25"], "china"),
        new(FlagColor.UnitedStates, "United States", FlagCategory.Country, ["#B22234", "#FFFFFF", "#B22234", "#FFFFFF", "#B22234", "#FFFFFF", "#B22234", "#FFFFFF", "#B22234", "#FFFFFF", "#B22234", "#FFFFFF", "#B22234"], "united-states"),
        new(FlagColor.Indonesia, "Indonesia", FlagCategory.Country, ["#E70011", "#FFFFFF"]),
        new(FlagColor.Pakistan, "Pakistan", FlagCategory.Country, ["#01411C"], "pakistan"),
        new(FlagColor.Nigeria, "Nigeria", FlagCategory.Country, ["#008751", "#FFFFFF", "#008751"], VerticalStripes: true),
        new(FlagColor.Brazil, "Brazil", FlagCategory.Country, ["#009C3B"], "brazil"),
        new(FlagColor.Bangladesh, "Bangladesh", FlagCategory.Country, ["#006A4E"], "bangladesh"),
        new(FlagColor.Russia, "Russia", FlagCategory.Country, ["#FFFFFF", "#0039A6", "#D52B1E"]),
        new(FlagColor.Mexico, "Mexico", FlagCategory.Country, ["#006847", "#FFFFFF", "#CE1126"], "mexico", VerticalStripes: true),

        // Kink
        new(FlagColor.Leather, "Leather Pride", FlagCategory.Kink, ["#000000", "#2A2A7F", "#000000", "#2A2A7F", "#FFFFFF", "#2A2A7F", "#000000", "#2A2A7F", "#000000"], "leather"),
        new(FlagColor.BdsmRights, "BDSM Rights", FlagCategory.Kink, ["#000000", "#2A2A7F", "#000000", "#2A2A7F", "#FFFFFF", "#2A2A7F", "#000000", "#2A2A7F", "#000000"], "bdsm-rights"),
        new(FlagColor.PuppyPride, "Puppy Pride", FlagCategory.Kink, ["#000000", "#2A2A7F", "#FFFFFF", "#2A2A7F", "#000000"], "puppy-pride"),
        new(FlagColor.RubberPride, "Rubber Pride", FlagCategory.Kink, ["#000000", "#FFD200", "#000000"], "rubber-pride")
    ];

    private static readonly FrozenDictionary<FlagColor, FlagDefinition> ByVariant = Definitions.ToFrozenDictionary(static d => d.Variant);
    private static readonly FrozenDictionary<FlagColor, string> Backgrounds = Definitions.ToFrozenDictionary(static d => d.Variant, static d => BuildGradient(d.Stripes, d.VerticalStripes));

    /// <summary>Every built-in flag, grouped by category in display order.</summary>
    public static IReadOnlyList<FlagDefinition> All => Definitions;

    public static FlagDefinition Get(FlagColor variant) {
        return ByVariant.TryGetValue(variant, out FlagDefinition? definition) ? definition : ByVariant[FlagColor.RainbowOriginal];
    }

    public static IEnumerable<FlagDefinition> InCategory(FlagCategory category) {
        return Definitions.Where(d => d.Category == category);
    }

    internal static string GetBackground(FlagColor variant) {
        return Backgrounds.TryGetValue(variant, out string? background) ? background : Backgrounds[FlagColor.RainbowOriginal];
    }

    internal static string BuildGradient(IReadOnlyList<string> colors, bool vertical) {
        double segment = 100.0 / colors.Count;

        string[] stops = new string[colors.Count];
        for (int i = 0; i < colors.Count; i++) {
            stops[i] = $"{colors[i]} {Css(i * segment)}% {Css((i + 1) * segment)}%";
        }

        return $"linear-gradient(to {(vertical ? "right" : "bottom")}, {string.Join(", ", stops)})";
    }

    // CSS needs invariant numbers, and four decimals keeps the markup short without visible rounding
    internal static string Css(double value) {
        return value.ToString("0.####", CultureInfo.InvariantCulture);
    }
}