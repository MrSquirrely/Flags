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
        new(FlagColor.Transfeminine, "Transfeminine", FlagCategory.Pride, ["#73DEFF", "#FFE2EE", "#FFB5D6", "#FE8CBF", "#FFB5D6", "#FFE2EE", "#73DEFF"]),
        new(FlagColor.Transmasculine, "Transmasculine", FlagCategory.Pride, ["#FF8ABD", "#CDF5FE", "#9AEBFF", "#74DFFF", "#9AEBFF", "#CDF5FE", "#FF8ABD"]),
        new(FlagColor.Pangender, "Pangender", FlagCategory.Pride, ["#FFF798", "#FEDDCD", "#FFEBFB", "#FFFFFF", "#FFEBFB", "#FEDDCD", "#FFF798"]),
        new(FlagColor.Genderflux, "Genderflux", FlagCategory.Pride, ["#F47694", "#F2A2B9", "#CECECE", "#7CE0F7", "#3ECDF9", "#FFF48D"]),
        new(FlagColor.Neutrois, "Neutrois", FlagCategory.Pride, ["#FFFFFF", "#1F9F00", "#000000"]),
        new(FlagColor.Androgyne, "Androgyne", FlagCategory.Pride, ["#FE007F", "#9832FF", "#00B8E7"]),
        new(FlagColor.Maverique, "Maverique", FlagCategory.Pride, ["#FFF344", "#FFFFFF", "#F49622"]),
        new(FlagColor.Xenogender, "Xenogender", FlagCategory.Pride, ["#FF6692", "#FF9A98", "#FFB883", "#FBFFA8", "#85BCFF", "#9D85FF", "#A510FF"]),
        new(FlagColor.TwoSpirit, "Two-Spirit", FlagCategory.Pride, ["#E40303", "#FF8C00", "#FFED00", "#008026", "#24408E", "#732982"], "two-spirit"),
        new(FlagColor.Queer, "Queer", FlagCategory.Pride, ["#000000", "#99D9EA", "#00A2E8", "#B5E61D", "#FFFFFF", "#FFC90E", "#FD6666", "#FFAEC9"]),
        new(FlagColor.Abrosexual, "Abrosexual", FlagCategory.Pride, ["#75CA92", "#B3E4C7", "#FFFFFF", "#E695B5", "#D9446A"]),
        new(FlagColor.Sapphic, "Sapphic", FlagCategory.Pride, ["#FD8BA8", "#FBF2FF", "#C76BC5"], "sapphic"),
        new(FlagColor.LabrysLesbian, "Labrys Lesbian", FlagCategory.Pride, ["#A20DA2"], "labrys-lesbian"),
        new(FlagColor.StraightAlly, "Straight Ally", FlagCategory.Pride, ["#000000", "#FFFFFF", "#000000", "#FFFFFF", "#000000", "#FFFFFF"], "straight-ally"),
        new(FlagColor.Twink, "Twink", FlagCategory.Pride, ["#FFB0FF", "#FFFFFF", "#FFFF80"], "twink"),

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
        new(FlagColor.RubberPride, "Rubber Pride", FlagCategory.Kink, ["#000000", "#FFD200", "#000000"], "rubber-pride"),
        // Leather crossovers: community recolors of the leather layout in another flag's colors
        new(FlagColor.LeatherTransgender, "Trans Leather", FlagCategory.Kink, ["#000000", "#5BCEFA", "#000000", "#F5A9B8", "#FFFFFF", "#F5A9B8", "#000000", "#5BCEFA", "#000000"], "leather-transgender"),
        new(FlagColor.LeatherAsexual, "Ace Leather", FlagCategory.Kink, ["#000000", "#800080", "#000000", "#A3A3A3", "#FFFFFF", "#A3A3A3", "#000000", "#800080", "#000000"], "leather-asexual"),
        new(FlagColor.LeatherBisexual, "Bi Leather", FlagCategory.Kink, ["#000000", "#D60270", "#000000", "#D60270", "#9B4F96", "#0038A8", "#000000", "#0038A8", "#000000"], "leather-bisexual"),
        new(FlagColor.LeatherPansexual, "Pan Leather", FlagCategory.Kink, ["#000000", "#FF218C", "#000000", "#FF218C", "#FFD800", "#21B1FF", "#000000", "#21B1FF", "#000000"], "leather-pansexual"),
        new(FlagColor.LeatherNonBinary, "Non-Binary Leather", FlagCategory.Kink, ["#000000", "#FCF434", "#000000", "#FFFFFF", "#9C59D1", "#FFFFFF", "#000000", "#FCF434", "#000000"], "leather-non-binary"),

        // Community
        new(FlagColor.BearBrotherhood, "Bear Brotherhood", FlagCategory.Community, ["#623804", "#D56300", "#FEDD63", "#FEE6B8", "#FFFFFF", "#555555", "#000000"], "bear-brotherhood"),
        new(FlagColor.DisabilityPride, "Disability Pride", FlagCategory.Community, ["#595959"], "disability-pride"),
        new(FlagColor.Neurodiversity, "Neurodiversity", FlagCategory.Community, ["#FFFFFF"], "neurodiversity")
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