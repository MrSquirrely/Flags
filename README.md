# Waving Flags

A Blazor component library providing fluid, CSS-animated waving pride flags. The wave effects use a synchronized columnar delay to achieve a heavy, realistic fabric feel.

This project is inspired by the animation work of [Josh W. Comeau](https://www.joshwcomeau.com/animation/pride-flags/).

---

## Installation & Setup

To use these components, ensure your project targets `.NET 9.0` or higher and references your Blazor environment. The library layout follows the structure of `mrsquirrely/flags` and includes the following core files:
* `Flags.csproj` - The project configuration file.
* `Components/Flag.razor` - The main Blazor component for rendering the flag UI.
* `Components/Flag.razor.css` - The scoped CSS file handling the wave animations.
* `FlagColors.cs` - The backend C# file containing predefined color palettes.

Add the library namespace to your `_Imports.razor` file:

```razor
@using Flags
```

---

## Usage

You can embed the flag component directly into your Razor views, MVC `.cshtml` pages, or other Blazor components.

### Basic Example
```razor
<Flag Variant="trans" Width="300"/>
```

### Custom Colors Example
```razor
<Flag CustomColors="@(new string[] { "hsl(0deg 90% 55%)", "hsl(120deg 90% 55%)", "hsl(240deg 90% 55%)" })" NumOfColumns="15"/>
```

---

## Component Parameters

The `Components/Flag.razor` architecture supports customization through the following parameters:

* **`Variant`** (`string`): The name of a predefined flag color scheme from `FlagColors.cs`. Defaults to `"rainbow"`.
* **`CustomColors`** (`string[]?`): An optional array of CSS color strings (e.g., HEX, HSL, RGB) to build a custom top-to-bottom striped flag. If provided, this overrides the selected `Variant`.
* **`Width`** (`double`): The rendering target width of the flag in pixels. Defaults to `200`.
* **`NumOfColumns`** (`int`): The number of individual vertical elements making up the flag. More columns create a higher-fidelity wave. Defaults to `10`.
* **`StaggeredDelay`** (`int`): The animation delay offset (in milliseconds) added sequentially per column to establish the fluid ripple effect. Defaults to `150`.
* **`Billow`** (`double`): The intensity / peak vertical distance (in pixels) of the ripple animation oscillation. Defaults to `3`.

---

## Predefined Variants

The library includes built-in color maps in `FlagColors.cs` for the following flag variants:

| Variant Key | Description / Colors Included |
| :--- | :--- |
| `"rainbow"` | 8-stripe representation (including dark accent bands) |
| `"rainbow-original"` | Classic 6-stripe layout |
| `"trans"` | Pastel blue, pastel pink, and white stripes |
| `"pan"` | Bright magenta, yellow, and cyan stripes |
| `"bi"` | Deep pink, purple, and blue stripes |
| `"nonbinary"` | Yellow, white, purple, and dark gray stripes |
| `"lesbian"` | Seven-stripe shades of orange, white, and pink |

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