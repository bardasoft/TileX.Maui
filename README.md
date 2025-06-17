<a href="https://www.buymeacoffee.com/edgomez" target="_blank"><img src="https://cdn.buymeacoffee.com/buttons/default-orange.png" alt="Buy Me A Pizaz" height="41" width="174"></a>

**🚀 WinTile - A Dynamic Live Tile Control for .NET MAUI**

WinTile is a customizable live tile control for .NET MAUI, designed to support dynamic flipping animations, multiple tile sizes, and flexible UI customization. Whether you need interactive dashboard tiles or responsive app elements, WinTile provides a lightweight and smooth experience.


# Features:

✅ Supports Small, Medium, Wide, and Large tile sizes
✅ Animated flipping mechanism with configurable timing
✅ Customizable appearance, including title visibility and font sizes
✅ Optimized memory usage with event cleanup & cancellation handling

# Installation & Usage:

```
using TileX.Maui.Extensions;
using CommunityToolkit.Maui; (important)

   public static MauiApp CreateMauiApp() {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>()
                .UseTileX()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts => {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });
```

Add this to xaml

```
   xmlns:tile="clr-namespace:TileX.Maui.Controls;assembly=TileX.Maui"
```
# WinTile Control Documentation

The `WinTile` control is a customizable tile control based on Windows Phone live tiles. It provides various properties to adjust its appearance and behavior, including size, color, content, and flipping animations.

## Properties

The following table summarizes the properties available in the `WinTile` control, along with their descriptions and example values.

[View WinTile Control Properties](./WinTileProperties.html)

## Usage Example

Here is a simple example of how to use the `WinTile` control in XAML:

```xml
<tile:WinTile
    TileSize="TileSizes.Medium"
    TileColor="Color.FromArgb('#FF5733')"
    TileTitle="My Tile"
    TileContent="This is a sample tile."
    Command="{Binding MyCommand}"
    CommandParameter="{Binding MyParameter}" />

