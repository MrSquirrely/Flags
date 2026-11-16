namespace Flags;

/// <summary>Describes one built-in flag.</summary>
/// <param name="Variant">The flag this definition belongs to.</param>
/// <param name="Name">A human-readable name, e.g. "Progress Pride".</param>
/// <param name="Category">The group the flag belongs to.</param>
/// <param name="Stripes">Stripe colors, top to bottom (left to right when <paramref name="VerticalStripes"/> is set). For flags with an <paramref name="Image"/> they are the fallback shown while the image loads.</param>
/// <param name="Image">The SVG design under <c>_content/Flags/flags/</c>, without the extension, or <see langword="null"/> for plain striped flags.</param>
/// <param name="VerticalStripes">Whether the stripes run vertically.</param>
public sealed record FlagDefinition(FlagColor Variant, string Name, FlagCategory Category, IReadOnlyList<string> Stripes, string? Image = null, bool VerticalStripes = false);