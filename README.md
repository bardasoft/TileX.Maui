**🚀 WinTile - A Dynamic Live Tile Control for .NET MAUI**

WinTile is a customizable live tile control for .NET MAUI, designed to support dynamic flipping animations, multiple tile sizes, and flexible UI customization. Whether you need interactive dashboard tiles or responsive app elements, WinTile provides a lightweight and smooth experience.


# Features:

✅ Supports Small, Medium, Wide, and Large tile sizes
✅ Animated flipping mechanism with configurable timing
✅ Customizable appearance, including title visibility and font sizes
✅ Optimized memory usage with event cleanup & cancellation handling

# Installation & Usage:

```using TileX.Maui.Extensions;
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

| Property                        | Type                | Default Value                | Description                                                                                     | Example Value                |
|---------------------------------|---------------------|------------------------------|--------------------------------------------------------------------------------------------------|-------------------------------|
| `TileSize`                     | `TileSizes`         | `TileSizes.Medium`          | The size of the tile. Options include Small, Medium, Wide, and Large.                          | `TileSizes.Large`            |
| `TileColor`                    | `Color`             | `Color.FromArgb("#1753C9")` | The background color of the tile.                                                               | `Color.FromArgb("#FF0000")`  |
| `TileTransparency`             | `double`            | `1.0`                        | The transparency level of the tile (0.0 to 1.0).                                                | `0.5`                         |
| `TileTitle`                    | `string`            | `null`                       | The title text displayed on the tile.                                                           | `"My Tile Title"`            |
| `TileContent`                  | `string`            | `null`                       | The content text displayed on the tile.                                                         | `"Some content here"`        |
| `TitleTextColor`               | `Color`             | `Colors.White`               | The color of the title text.                                                                    | `Colors.Yellow`              |
| `TitleFontSize`                | `double`            | `8.0`                        | The font size of the title text.                                                                | `12.0`                        |
| `TitleVerticalPosition`        | `TextAlignment`     | `TextAlignment.End`         | The vertical alignment of the title text.                                                       | `TextAlignment.Start`        |
| `TitleHorizontalPosition`      | `TextAlignment`     | `TextAlignment.Start`       | The horizontal alignment of the title text.                                                     | `TextAlignment.Center`       |
| `TitleFontAttributes`          | `FontAttributes`    | `FontAttributes.None`       | The font attributes of the title text (e.g., Bold, Italic).                                     | `FontAttributes.Bold`        |
| `TitlePadding`                 | `Thickness`         | `new Thickness(5)`          | The padding around the title text.                                                              | `new Thickness(10)`          |
| `IsTitleVisible`               | `bool`              | `true`                      | Indicates whether the title is visible.                                                         | `false`                      |
| `Command`                      | `ICommand`          | `null`                      | The command to execute when the tile is tapped.                                                 | `new Command(() => { })`     |
| `CommandParameter`             | `object`            | `null`                      | The parameter to pass to the command when executed.                                             | `someParameter`              |
| `FlipIntervalSeconds`          | `int`               | `7`                         | The interval in seconds for flipping the tile.                                                  | `10`                         |
| `BackSideDurationSeconds`      | `int`               | `5`                         | The duration in seconds the back side of the tile is displayed.                                 | `3`                          |
| `IsIconFont`                   | `bool`              | `true`                      | Indicates whether the icon is a font icon.                                                      | `false`                      |
| `CornerRadius`                 | `int`               | `8`                         | The corner radius of the tile.                                                                  | `12`                         |
| `IconFont`                     | `string`            | `null`                      | The font icon to display on the tile.                                                           | `"&#xf007;"`                 |
| `IconFontFamily`               | `string`            | `null`                      | The font family of the icon font.                                                               | `"FontAwesome"`              |
| `IconFontColor`                | `Color`             | `Colors.Black`              | The color of the icon font.                                                                     | `Colors.Red`                 |
| `IconFontSize`                 | `double`            | `28.0`                      | The font size of the icon font.                                                                 | `32.0`                       |
| `VerticalIconAlignment`        | `TextAlignment`     | `TextAlignment.Center`      | The vertical alignment of the icon.                                                             | `TextAlignment.Start`        |
| `HorizontalIconAlignment`      | `TextAlignment`     | `TextAlignment.Center`      | The horizontal alignment of the icon.                                                           | `TextAlignment.End`          |
| `Image`                        | `ImageSource`       | `null`                      | The image to display on the tile.                                                               | `ImageSource.FromFile("image.png")` |
| `ImageWidth`                   | `double`            | `0.0`                       | The width of the image.                                                                         | `100.0`                      |
| `ImageHeight`                  | `double`            | `0.0`                       | The height of the image.                                                                        | `100.0`                      |
| `ImageVerticalPosition`        | `LayoutOptions`     | `LayoutOptions.Center`      | The vertical position of the image.                                                             | `LayoutOptions.Start`        |
| `ImageHorizontalPosition`      | `LayoutOptions`     | `LayoutOptions.Center`      | The horizontal position of the image.                                                           | `LayoutOptions.End`          |
| `ContentFontSize`              | `double`            | `12.0`                      | The font size of the content text.                                                              | `14.0`                       |
| `ContentFontAttributes`        | `FontAttributes`    | `FontAttributes.None`       | The font attributes of the content text.                                                        | `FontAttributes.Italic`      |
| `ContentTextColor`             | `Color`             | `Colors.White`              | The color of the content text.                                                                  | `Colors.Gray`                |
| `ContentPadding`               | `Thickness`         | `new Thickness(5)`          | The padding around the content text.                                                            | `new Thickness(10)`          |
| `ContentVerticalPosition`      | `TextAlignment`     | `TextAlignment.Start`       | The vertical alignment of the content text.                                                     | `TextAlignment.End`          |
| `ContentHorizontalPosition`    | `TextAlignment`     | `TextAlignment.Start`       | The horizontal alignment of the content text.                                                   | `TextAlignment.Center`       |

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

