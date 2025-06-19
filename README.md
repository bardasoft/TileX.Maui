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

| Property                   | Type            | Default Value                | Description                                                          
|----------------------------|-----------------|------------------------------|----------------------------------------------------------------------
| `TileSize`                 | `Enum`          | `TileSizes.Medium`           | The size of the tile. Options include Small, Medium, Wide, and Large.
| `TileColor`                | `Color`         | `Color.FromArgb("#1753C9")` | The background color of the tile.                                    
| `TileTransparency`         | `double`        | `1.0`                        | The transparency level of the tile (0.0 to 1.0).                     
| `TileTitle`                | `string`        | `null`                       | The title text displayed on the tile.                                
| `TileContent`              | `string`        | `null`                       | The content text displayed on the tile.                              
| `TitleTextColor`           | `Color`         | `Colors.White`               | The color of the title text.                                         
| `TitleFontSize`            | `double`        | `8.0`                        | The font size of the title text.                                     
| `TitleVerticalPosition`    | `TextAlignment` | `TextAlignment.End`          | The vertical alignment of the title text.                            
| `TitleHorizontalPosition`  | `TextAlignment` | `TextAlignment.Start`        | The horizontal alignment of the title text.                          
| `TitleFontAttributes`      | `FontAttributes`| `FontAttributes.None`        | The font attributes of the title text (e.g., Bold, Italic).          
| `TitlePadding`             | `Thickness`     | `new Thickness(5)`           | The padding around the title text.                                   
| `IsTitleVisible`           | `bool`          | `true`                       | Indicates whether the title is visible.                              
| `Command`                  | `ICommand`      | `null`                       | The command to execute when the tile is tapped.                      
| `CommandParameter`         | `object`        | `null`                       | The parameter to pass to the command when executed.                  
| `FlipIntervalSeconds`      | `int`           | `7`                          | The interval in seconds for flipping the tile.                       
| `BackSideDurationSeconds`  | `int`           | `5`                          | The duration in seconds the back side of the tile is displayed.      
| `IsIconFont`               | `bool`          | `true`                       | Indicates whether the icon is a font icon.                           
| `CornerRadius`             | `int`           | `8`                          | The corner radius of the tile.                                       
| `Symbol`                   | `Enum`          | `null`                       | The font icon to display on the tile.                                       
| `IconFontFamily`           | `string`        | `fa`                         | The font family of the icon font.                                       
| `IconFontColor`            | `Color`         | `Colors.Black`               | The color of the icon font.                                          
| `IconFontSize`             | `double`        | `28.0`                       | The font size of the icon font.                                      
| `VerticalIconAlignment`    | `TextAlignment` | `TextAlignment.Center`       | The vertical alignment of the icon.                                  
| `HorizontalIconAlignment`  | `TextAlignment` | `TextAlignment.Center`       | The horizontal alignment of the icon.                                
| `Image`                    | `ImageSource`   | `null`                       | The image to display on the tile.                                    
| `ImageWidth`               | `double`        | `Scale with Tile`            | The width of the image.                                              
| `ImageHeight`              | `double`        | `Scale with Tile`            | The height of the image.                                             
| `ImageVerticalPosition`    | `LayoutOptions` | `LayoutOptions.Center`       | The vertical position of the image.                                  
| `ImageHorizontalPosition`  | `LayoutOptions` | `LayoutOptions.Center`       | The horizontal position of the image.                                
| `ContentFontSize`          | `double`        | `12.0`                       | The font size of the content text.                                   
| `ContentFontAttributes`    | `FontAttributes`| `FontAttributes.None`        | The font attributes of the content text.                             
| `ContentTextColor`         | `Color`         | `Colors.White`               | The color of the content text.                                       
| `ContentPadding`           | `Thickness`     | `new Thickness(5)`           | The padding around the content text.                                 
| `ContentVerticalPosition`  | `TextAlignment` | `TextAlignment.Start`        | The vertical alignment of the content text.                          
| `ContentHorizontalPosition`| `TextAlignment` | `TextAlignment.Start`        | The horizontal alignment of the content text.                        

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

