using CommunityToolkit.Maui;

namespace TileX.Maui.Extensions;

public static class TileXExtensions {
    public static MauiAppBuilder UseTileX(this MauiAppBuilder builder) {
        // Register the TileX service
        builder.UseMauiCommunityToolkit(); // important!
        // Optional: Register any custom handlers if needed
        return builder;
    }
}
