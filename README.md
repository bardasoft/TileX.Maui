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

| Property                   | Type             | Description                                                                                  | Default                          | Example                        |
|----------------------------|------------------|----------------------------------------------------------------------------------------------|----------------------------------|--------------------------------|
| TileSize                   | TileSizes        | Size of the tile: Small, Medium, Wide, or Large.                                             | TileSizes.Medium                 | TileSizes.Large               |
| TileColor                  | Color            | Background color of the tile.                                                                | Color.FromArgb("#1753C9")        | Color.FromArgb("#FF0000")     |
| TileTransparency           | double           | Transparency level (0.0 to 1.0).                                                              | 1.0                              | 0.5                            |
| TileTitle                  | string           | Title text displayed on the tile.                                                            | null                             | "My Tile Title"               |
| TileContent                | string           | Content text displayed on the tile.                                                          | null                             | "Some content here"           |
| TitleTextColor             | Color            | Color of the title text.                                                                     | Colors.White                     | Colors.Yellow                 |
| TitleFontSize              | double           | Font size of the title text.                                                                 | 8.0                              | 12.0                           |
| TitleVerticalPosition      | TextAlignment    | Vertical alignment of title text.                                                            | TextAlignment.End                | TextAlignment.Start           |
| TitleHorizontalPosition    | TextAlignment    | Horizontal alignment of title text.                                                          | TextAlignment.Start              | TextAlignment.Center          |
| TitleFontAttributes        | FontAttributes   | Font style of the title text (e.g., Bold, Italic).                                           | FontAttributes.None              | FontAttributes.Bold           |
| TitlePadding               | Thickness        | Padding around the title text.                                                               | new Thickness(5)                 | new Thickness(10)             |
| IsTitleVisible             | bool             | Whether the title is visible.                                                                | true                             | false                          |
| Command                    | ICommand         | Command executed when the tile is tapped.                                                    | null                             | new Command(() => { })        |
| CommandParameter           | object           | Parameter passed to the command.                                                             | null                             | someParameter                 |
| FlipIntervalSeconds        | int              | Interval in seconds between tile flips.                                                      | 7                                | 10                             |
| BackSideDurationSeconds    | int              | Duration in seconds that the back side is shown.                                             | 5                                | 3                              |
| IsIconFont                 | bool             | Whether the icon is a font icon.                                                             | true                             | false                          |
| CornerRadius               | int              | Corner radius of the tile.                                                                   | 8                                | 12                             |
| IconFont                   | string           | Font icon displayed on the tile.                                                             | null                             | "&#xf007;"                    |
| IconFontFamily             | string           | Font family of the icon.                                                                     | null                             | "FontAwesome"                 |
| IconFontColor              | Color            | Color of the icon font.                                                                      | Colors.Black                     | Colors.Red                    |
| IconFontSize               | double           | Font size of the icon font.                                                                  | 28.0                             | 32.0                           |
| VerticalIconAlignment      | TextAlignment    | Vertical alignment of the icon.                                                              | TextAlignment.Center             | TextAlignment.Start           |
| HorizontalIconAlignment    | TextAlignment    | Horizontal alignment of the icon.                                                            | TextAlignment.Center             | TextAlignment.End             |
| Image                      | ImageSource      | Image displayed on the tile.                                                                 | null                             | ImageSource.FromFile("image.png") |
| ImageWidth                 | double           | Width of the image.                                                                          | 0.0                              | 100.0                          |
| ImageHeight                | double           | Height of the image.                                                                         | 0.0                              | 100.0                          |
| ImageVerticalPosition      | LayoutOptions    | Vertical alignment of the image.                                                             | LayoutOptions.Center             | LayoutOptions.Start           |
| ImageHorizontalPosition    | LayoutOptions    | Horizontal alignment of the image.                                                           | LayoutOptions.Center             | LayoutOptions.End             |
| ContentFontSize            | double           | Font size of the content text.                                                               | 12.0                             | 14.0                           |
| ContentFontAttributes      | FontAttributes   | Font style of the content text (e.g., Italic).                                               | FontAttributes.None              | FontAttributes.Italic         |
| ContentTextColor           | Color            | Color of the content text.                                                                   | Colors.White                     | Colors.Gray                   |
| ContentPadding             | Thickness        | Padding around the content text.                                                             | new Thickness(5)                 | new Thickness(10)             |
| ContentVerticalPosition    | TextAlignment    | Vertical alignment of the content text.                                                      | TextAlignment.Start              | TextAlignment.End             |
| ContentHorizontalPosition  | TextAlignment    | Horizontal alignment of the content text.                                                    | TextAlignment.Start              | TextAlignment.Center          |


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

