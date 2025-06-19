namespace TileX.Maui.Extensions;

public static class TileXExtensions {

    public static MauiAppBuilder UseTileX(this MauiAppBuilder builder) {

        builder.UseMauiCommunityToolkit();

        builder.ConfigureFonts(fonts => {
            fonts.AddFont("fa-brands-400.ttf", "fa");
        });

        return builder;

    }
}
