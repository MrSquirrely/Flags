# Waving Flags

A Blazor component library providing fluid, CSS-animated waving flags: LGBTQ+ pride flags, the ten most populous countries' flags, kink pride flags, community flags, or your own stripes and logo. The wave effect uses a synchronized columnar delay to achieve a heavy, realistic fabric feel.

This project is inspired by the animation work of [Josh W. Comeau](https://www.joshwcomeau.com/animation/pride-flags/).

---

## Installation & Setup

Your project needs to target `.NET 11.0` or higher. The library contains:
* `Components/Flag.razor` - The `Flag` component.
* `Components/Flag.razor.css` - Scoped CSS for the wave animation and the designed flags.
* `wwwroot/flags/*.svg` - The designs for flags that are more than plain stripes (Progress Pride, countries, kink flags, ...).
* `FlagCatalog.cs`, `FlagDefinition.cs`, `FlagColor.cs`, `FlagCategory.cs` - The built-in flags.

Add the namespaces to your `_Imports.razor` file:

```razor
@using Flags
@using Flags.Components
```

Blazor apps pick up the component's stylesheet through their `{App}.styles.css` bundle. Razor Pages and MVC apps link it directly:

```html
<link href="~/_content/Flags/Flags.bundle.scp.css" rel="stylesheet" asp-append-version="true" />
```

---

## Usage

You can embed the flag component directly into your Razor views, MVC `.cshtml` pages, or other Blazor components.

### Basic Example
```razor
<Flag Variant="FlagColor.Transgender" Width="300"/>
```

### Custom Colors Example
```razor
<Flag CustomColors="@(new string[] { "hsl(0deg 90% 55%)", "hsl(120deg 90% 55%)", "hsl(240deg 90% 55%)" })" NumOfColumns="15"/>
```

### Logo Example
```razor
<Flag LogoUrl="/images/my-custom-logo.svg" Variant="FlagColor.RainbowOriginal"/>
```

### Listing Every Flag
```razor
@foreach (FlagDefinition flag in FlagCatalog.InCategory(FlagCategory.Pride)) {
    <Flag Variant="flag.Variant" Width="90" Label="@flag.Name"/>
}
```

### Razor Pages / MVC
```cshtml
<component type="typeof(Flag)" render-mode="Static" param-Variant="@FlagColor.ProgressPride" param-Width="(double)64" />
```

---

## Component Parameters

* **`Variant`** (`FlagColor`): A built-in flag. Defaults to `FlagColor.RainbowOriginal`.
* **`CustomColors`** (`string[]?`): An optional array of CSS color strings (e.g., HEX, HSL, RGB) to build a custom top-to-bottom striped flag. If provided, this overrides the selected `Variant`.
* **`Width`** (`double`): The rendering target width of the flag in pixels, rounded to a whole number of pixels per column. The height follows at 3:2. Defaults to `200`.
* **`NumOfColumns`** (`int`): The number of individual vertical elements making up the flag. More columns create a higher-fidelity wave. Defaults to `10`; values below `1` are treated as `1`.
* **`StaggeredDelay`** (`int`): The animation delay offset (in milliseconds) added sequentially per column to establish the fluid ripple effect. Defaults to `150`.
* **`Billow`** (`double`): The intensity / peak vertical distance (in pixels) of the ripple animation oscillation. Defaults to `3`. Animation is disabled for visitors who set `prefers-reduced-motion`.
* **`LogoUrl`** (`string`): An optional URL to an image or SVG to display centered across the waving flag.
* **`Label`** (`string?`): An optional accessible name (e.g. `"Transgender pride flag"`). When set, the flag is exposed as an image with that name; when omitted, the flag is treated as decorative and hidden from screen readers.

---

## Built-in Flags

`FlagCatalog.All` lists every flag as a `FlagDefinition` (variant, display name, category, stripe colors), and `FlagCatalog.Get(variant)` returns one. Flags marked *design* are drawn from an SVG in `wwwroot/flags`; their stripe colors show while the SVG loads.

### Pride (`FlagCategory.Pride`)

| `FlagColor` | Name | Notes |
| :--- | :--- | :--- |
| `RainbowOriginal` | Rainbow Pride | Classic 6 stripes |
| `Rainbow` | Philadelphia Pride | 6 stripes plus black and brown |
| `GilbertBaker` | Gilbert Baker Pride (1978) | Original 8 stripes |
| `ProgressPride` | Progress Pride | Design |
| `IntersexInclusiveProgress` | Intersex-Inclusive Progress Pride | Design |
| `Lesbian` | Lesbian | 5 stripes |
| `Gay` | Gay Men | 7 stripes |
| `Bisexual` | Bisexual | 2:1:2 stripes |
| `Pansexual` | Pansexual | |
| `Polysexual` | Polysexual | |
| `Omnisexual` | Omnisexual | |
| `Asexual` | Asexual | |
| `Demisexual` | Demisexual | Design |
| `Graysexual` | Graysexual | |
| `Aromantic` | Aromantic | |
| `Demiromantic` | Demiromantic | Design |
| `AroAce` | Aroace | |
| `Polyamory` | Polyamory | Design, the 2022 tricolor |
| `Transgender` | Transgender | |
| `NonBinary` | Non-Binary | |
| `Genderfluid` | Genderfluid | |
| `Genderqueer` | Genderqueer | |
| `Agender` | Agender | |
| `Bigender` | Bigender | |
| `Demigirl` | Demigirl | |
| `Demiboy` | Demiboy | |
| `Intersex` | Intersex | Design |
| `Transfeminine` | Transfeminine | |
| `Transmasculine` | Transmasculine | |
| `Pangender` | Pangender | |
| `Genderflux` | Genderflux | |
| `Neutrois` | Neutrois | |
| `Androgyne` | Androgyne | |
| `Maverique` | Maverique | |
| `Xenogender` | Xenogender | |
| `TwoSpirit` | Two-Spirit | Design, rainbow with two feathers in a circle |
| `Queer` | Queer | The 2015 flag, 8 stripes |
| `Abrosexual` | Abrosexual | |
| `Sapphic` | Sapphic | Design, stripes with a violet |
| `LabrysLesbian` | Labrys Lesbian | Design, violet with a black triangle and a labrys |
| `StraightAlly` | Straight Ally | Design, black and white stripes with a rainbow chevron |
| `Twink` | Twink | Design, interlocked Mars symbols |

### Countries (`FlagCategory.Country`)

The ten most populous countries. All flags are drawn at 3:2, so flags with other official proportions (e.g. the United States at 19:10) are slightly stretched. Brazil and Mexico use simplified emblems, without the motto or the full coat of arms.

`India`, `China`, `UnitedStates`, `Indonesia`, `Pakistan`, `Nigeria`, `Brazil`, `Bangladesh`, `Russia`, `Mexico`

### Kink (`FlagCategory.Kink`)

| `FlagColor` | Name | Notes |
| :--- | :--- | :--- |
| `Leather` | Leather Pride | 9 black and blue stripes, white center, red heart |
| `BdsmRights` | BDSM Rights | Leather stripes with a simplified red BDSM emblem |
| `PuppyPride` | Puppy Pride | Diagonal stripes with a red bone |
| `RubberPride` | Rubber Pride | Black with a kinked gold band outlined in red |
| `LeatherTransgender` | Trans Leather | Leather layout in trans colors |
| `LeatherAsexual` | Ace Leather | Leather layout in ace colors |
| `LeatherBisexual` | Bi Leather | Leather layout in bi colors |
| `LeatherPansexual` | Pan Leather | Leather layout in pan colors |
| `LeatherNonBinary` | Non-Binary Leather | Leather layout in non-binary colors |

The leather crossovers are community recolors with many variants; these keep the leather stripe pattern and red heart.

### Community (`FlagCategory.Community`)

| `FlagColor` | Name | Notes |
| :--- | :--- | :--- |
| `BearBrotherhood` | Bear Brotherhood | Seven stripes with a black paw |
| `DisabilityPride` | Disability Pride | The 2021 low-flicker redesign |
| `Neurodiversity` | Neurodiversity | Rainbow infinity on white |

---

## Upgrading from the first release

* `FlagColors.Colors` is replaced by the read-only `FlagCatalog`.
* The `GetDisplayName()` extension on every `Enum` is removed (it clashed with apps that define their own); use `FlagCatalog.Get(variant).Name`.
* `Rainbow` is now named "Philadelphia Pride" and `RainbowOriginal` "Rainbow Pride".
* The bisexual flag now uses its official 2:1:2 stripe proportions.

---

## ⚖️ License & Open-Source Copyleft Requirements (GPLv3)

This component library is distributed under the **GNU General Public License v3 (GPLv3)**. Because the GPLv3 includes strong copyleft protections, using this library impacts your software architecture depending on **how** you host or render your application.

Please review the architectural requirements below to determine if your website must also be open-sourced under the GPLv3:

### 1. Blazor Server & Static Rendering Mode (Safe / Proprietary Allowed)
If your application runs via **Blazor Server** or utilizes **Static Rendering** (`RenderMode.Server` or `RenderMode.Static`), the component's underlying C# logic and library binaries remain strictly on your host hardware.
* **The Rule:** Under GPLv3 Section 2, *"Mere interaction with a user through a computer network, with no transfer of a copy, is not conveying."* Since no compiled assemblies are transferred to the user's browser, the copyleft trigger is not pulled.
* **Obligation:** You are **not** required to open-source your website. Your code can remain completely private, proprietary, and closed-source.

### 2. Blazor WebAssembly Mode (Triggers Open-Source Mandate)
If you configure this component to load and execute via **Blazor WebAssembly (WASM)** (`RenderMode.WebAssembly`), the server transmits the compiled library `.dll` assemblies to the visitor's computer to execute locally within their browser context.
* **The Rule:** Delivering compiled software bundles directly to a client's machine constitutes distribution ("conveying") under the GPLv3. Because your website's proprietary code directly interacts with, packages, or links against the GPLv3 component library to run in the client bundle, the complete client-side application becomes a combined work.
* **Obligation:** **You MUST make the full source code of your client application available under a GPLv3-compatible open-source license** to any users interacting with your application.
