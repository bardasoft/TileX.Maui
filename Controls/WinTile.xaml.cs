namespace TileX.Maui.Controls;

public partial class WinTile : ContentView {

    private bool _isFlipped = false;
    private CancellationTokenSource? _flipCancellation;
    private bool _isFlipping;
    private bool _isAnimating;

    public WinTile() {

        InitializeComponent();

        StartFlipLoop();

        Loaded += OnTileLoaded;
    }

    private void OnTileLoaded(object? sender, EventArgs e) {

        TileSize = GetSavedTileSize();

        UpdateSize(TileSize);
    }

    // Helper method to create BindableProperties with default values
    private static BindableProperty CreateBindableProperty<T>(string propertyName, T defaultValue) =>
        BindableProperty.Create(
            propertyName,
            typeof(T),
            typeof(WinTile),
            defaultValue);

    #region Tile properties

    public static readonly BindableProperty TileSizeProperty = CreateBindableProperty(nameof(TileSize), TileSizes.Medium);
    public TileSizes TileSize {
        get => (TileSizes)GetValue(TileSizeProperty);
        set => SetValue(TileSizeProperty, value);
    }

    public static readonly BindableProperty TileColorProperty = CreateBindableProperty(nameof(TileColor), Color.FromArgb("#1753C9"));
    public Color TileColor {
        get => (Color)GetValue(TileColorProperty);
        set => SetValue(TileColorProperty, value);
    }

    public static readonly BindableProperty TileTransparencyProperty = CreateBindableProperty(nameof(TileTransparency), 1.0);
    public double TileTransparency {
        get => (double)GetValue(TileTransparencyProperty);
        set => SetValue(TileTransparencyProperty, value);
    }

    public static readonly BindableProperty TitleProperty = BindableProperty.Create(
        nameof(TileTitle),
        typeof(string),
        typeof(WinTile),
        default(string));

    public string TileTitle {
        get => (string)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }

    public static readonly BindableProperty TileContentProperty = BindableProperty.Create(
        nameof(TileContent),
        typeof(string),
        typeof(WinTile),
        default(string));

    public string TileContent {
        get => (string)GetValue(TileContentProperty);
        set => SetValue(TileContentProperty, value);
    }

    public static readonly BindableProperty TitleTextColorProperty = CreateBindableProperty(nameof(TitleTextColor), Colors.White);
    public Color TitleTextColor {
        get => (Color)GetValue(TitleTextColorProperty);
        set => SetValue(TitleTextColorProperty, value);
    }

    public static readonly BindableProperty TitleFontSizeProperty = CreateBindableProperty(nameof(TitleFontSize), 8.0);
    public double TitleFontSize {
        get => (double)GetValue(TitleFontSizeProperty);
        set => SetValue(TitleFontSizeProperty, value);
    }

    public static readonly BindableProperty TitleVerticalPositionProperty = CreateBindableProperty(nameof(TitleVerticalPosition), TextAlignment.End);
    public TextAlignment TitleVerticalPosition {
        get => (TextAlignment)GetValue(TitleVerticalPositionProperty);
        set => SetValue(TitleVerticalPositionProperty, value);
    }

    public static readonly BindableProperty TitleHorizontalPositionProperty = CreateBindableProperty(nameof(TitleHorizontalPosition), TextAlignment.Start);
    public TextAlignment TitleHorizontalPosition {
        get => (TextAlignment)GetValue(TitleHorizontalPositionProperty);
        set => SetValue(TitleHorizontalPositionProperty, value);
    }

    public static readonly BindableProperty TitleFontAttributesProperty = BindableProperty.Create(nameof(TitleFontAttributes), typeof(FontAttributes), typeof(WinTile), FontAttributes.None);
    public FontAttributes TitleFontAttributes {
        get => (FontAttributes)GetValue(TitleFontAttributesProperty);
        set => SetValue(TitleFontAttributesProperty, value);
    }

    public static readonly BindableProperty TitlePaddingProperty = CreateBindableProperty(nameof(TitlePadding), new Thickness(5));
    public Thickness TitlePadding {
        get => (Thickness)GetValue(TitlePaddingProperty);
        set => SetValue(TitlePaddingProperty, value);
    }

    public static readonly BindableProperty IsTitleVisibleProperty = CreateBindableProperty(nameof(IsTitleVisible), true);
    public bool IsTitleVisible {
        get => (bool)GetValue(IsTitleVisibleProperty);
        private set => SetValue(IsTitleVisibleProperty, value);
    }

    public static readonly BindableProperty CommandProperty = BindableProperty.Create(nameof(Command), typeof(ICommand), typeof(WinTile));
    public ICommand Command {
        get => (ICommand)GetValue(CommandProperty);
        set => SetValue(CommandProperty, value);
    }

    public static readonly BindableProperty CommandParameterProperty = BindableProperty.Create(nameof(CommandParameter), typeof(object), typeof(WinTile));
    public object CommandParameter {
        get => GetValue(CommandParameterProperty);
        set => SetValue(CommandParameterProperty, value);
    }

    public static readonly BindableProperty FlipIntervalSecondsProperty = CreateBindableProperty(nameof(FlipIntervalSeconds), 7);
    public int FlipIntervalSeconds {
        get => (int)GetValue(FlipIntervalSecondsProperty);
        set => SetValue(FlipIntervalSecondsProperty, value);
    }

    public static readonly BindableProperty BackSideDurationSecondsProperty = CreateBindableProperty(nameof(BackSideDurationSeconds), 5);
    public int BackSideDurationSeconds {
        get => (int)GetValue(BackSideDurationSecondsProperty);
        set => SetValue(BackSideDurationSecondsProperty, value);
    }

    #endregion

    #region Icon font check property

    public static readonly BindableProperty IsIconFontProperty = CreateBindableProperty(nameof(IsIconFont), true);
    public bool IsIconFont {
        get => (bool)GetValue(IsIconFontProperty);
        set => SetValue(IsIconFontProperty, value);
    }

    public static readonly BindableProperty CornerRadiusProperty = CreateBindableProperty(nameof(CornerRadius), 8);
    public int CornerRadius {
        get => (int)GetValue(CornerRadiusProperty);
        set => SetValue(CornerRadiusProperty, value);
    }

    #endregion

    #region Icon font properties

    public static readonly BindableProperty IconFontProperty = BindableProperty.Create(nameof(IconFont), typeof(string), typeof(WinTile), default(string));
    public string IconFont {
        get => (string)GetValue(IconFontProperty);
        set => SetValue(IconFontProperty, value);
    }

    public static readonly BindableProperty IconFontFamilyProperty = BindableProperty.Create(nameof(IconFontFamily), typeof(string), typeof(WinTile), default(string));
    public string IconFontFamily {
        get => (string)GetValue(IconFontFamilyProperty);
        set => SetValue(IconFontFamilyProperty, value);
    }

    public static readonly BindableProperty IconFontColorProperty = BindableProperty.Create(nameof(IconFontColor), typeof(Color), typeof(WinTile), Colors.Black);
    public Color IconFontColor {
        get => (Color)GetValue(IconFontColorProperty);
        set => SetValue(IconFontColorProperty, value);
    }

    public static readonly BindableProperty IconFontSizeProperty = CreateBindableProperty(nameof(IconFontSize), 28.0);
    public double IconFontSize {
        get => (double)GetValue(IconFontSizeProperty);
        set => SetValue(IconFontSizeProperty, value);
    }

    public static readonly BindableProperty VerticalIconAlignmentProperty = CreateBindableProperty(nameof(VerticalIconAlignment), TextAlignment.Center);
    public TextAlignment VerticalIconAlignment {
        get => (TextAlignment)GetValue(VerticalIconAlignmentProperty);
        set => SetValue(VerticalIconAlignmentProperty, value);
    }

    public static readonly BindableProperty HorizontalIconAlignmentProperty = CreateBindableProperty(nameof(HorizontalIconAlignment), TextAlignment.Center);
    public TextAlignment HorizontalIconAlignment {
        get => (TextAlignment)GetValue(HorizontalIconAlignmentProperty);
        set => SetValue(HorizontalIconAlignmentProperty, value);
    }

    #endregion

    #region Icon image properties

    public static readonly BindableProperty ImageProperty = BindableProperty.Create(nameof(Image), typeof(ImageSource), typeof(WinTile), default(ImageSource));
    public ImageSource Image {
        get => (ImageSource)GetValue(ImageProperty);
        set => SetValue(ImageProperty, value);
    }

    public static readonly BindableProperty ImageWidthProperty = CreateBindableProperty(nameof(ImageWidth), 0.0);
    public double ImageWidth {
        get => (double)GetValue(ImageWidthProperty);
        set => SetValue(ImageWidthProperty, value);
    }

    public static readonly BindableProperty ImageHeightProperty = CreateBindableProperty(nameof(ImageHeight), 0.0);
    public double ImageHeight {
        get => (double)GetValue(ImageHeightProperty);
        set => SetValue(ImageHeightProperty, value);
    }

    public static readonly BindableProperty ImageVerticalPositionProperty = CreateBindableProperty(nameof(ImageVerticalPosition), LayoutOptions.Center);
    public LayoutOptions ImageVerticalPosition {
        get => (LayoutOptions)GetValue(ImageVerticalPositionProperty);
        set => SetValue(ImageVerticalPositionProperty, value);
    }

    public static readonly BindableProperty ImageHorizontalPositionProperty = CreateBindableProperty(nameof(ImageHorizontalPosition), LayoutOptions.Center);
    public LayoutOptions ImageHorizontalPosition {
        get => (LayoutOptions)GetValue(ImageHorizontalPositionProperty);
        set => SetValue(ImageHorizontalPositionProperty, value);
    }

    #endregion

    #region Tile content customization

    public static readonly BindableProperty ContentFontSizeProperty = CreateBindableProperty(nameof(ContentFontSize), 12.0);
    public double ContentFontSize {
        get => (double)GetValue(ContentFontSizeProperty);
        set => SetValue(ContentFontSizeProperty, value);
    }

    public static readonly BindableProperty ContentFontAttributesProperty = BindableProperty.Create(nameof(ContentFontAttributes), typeof(FontAttributes), typeof(WinTile), FontAttributes.None);
    public FontAttributes ContentFontAttributes {
        get => (FontAttributes)GetValue(ContentFontAttributesProperty);
        set => SetValue(ContentFontAttributesProperty, value);
    }

    public static readonly BindableProperty ContentTextColorProperty = CreateBindableProperty(nameof(ContentTextColor), Colors.White);
    public Color ContentTextColor {
        get => (Color)GetValue(ContentTextColorProperty);
        set => SetValue(ContentTextColorProperty, value);
    }

    public static readonly BindableProperty ContentPaddingProperty = CreateBindableProperty(nameof(ContentPadding), new Thickness(5));
    public Thickness ContentPadding {
        get => (Thickness)GetValue(ContentPaddingProperty);
        set => SetValue(ContentPaddingProperty, value);
    }

    public static readonly BindableProperty ContentVerticalPositionProperty = CreateBindableProperty(nameof(ContentVerticalPosition), TextAlignment.Start);
    public TextAlignment ContentVerticalPosition {
        get => (TextAlignment)GetValue(ContentVerticalPositionProperty);
        set => SetValue(ContentVerticalPositionProperty, value);
    }

    public static readonly BindableProperty ContentHorizontalPositionProperty = CreateBindableProperty(nameof(ContentHorizontalPosition), TextAlignment.Start);
    public TextAlignment ContentHorizontalPosition {
        get => (TextAlignment)GetValue(ContentHorizontalPositionProperty);
        set => SetValue(ContentHorizontalPositionProperty, value);
    }

    #endregion

    public void UpdateSize(TileSizes newSize) {
        var (width, height) = newSize switch {
            TileSizes.Small => (71.0, 71.0),
            TileSizes.Medium => (150.0, 150.0),
            TileSizes.Wide => (310.0, 150.0),
            TileSizes.Large => (310.0, 310.0),
            _ => (150.0, 150.0)
        };

        IsTitleVisible = newSize != TileSizes.Small;

        IconFontSize = newSize switch {
            TileSizes.Small => 40.0,
            TileSizes.Medium => 70.0,
            TileSizes.Wide => 80.0,
            TileSizes.Large => 150.0,
            _ => 70.0
        };

        ImageHeight = height;
        ImageWidth = width;
        WidthRequest = width;
        HeightRequest = height;

        SetValue(IsTitleVisibleProperty, IsTitleVisible);

        // Initialize flip state for small tile

        if(newSize == TileSizes.Small) {
            _isFlipped = false;
            FrontSide.IsVisible = true;
            BackSide.IsVisible = false;
        }
    }

    private void StartFlipLoop() {
        if(_isFlipping) {
            return;
        }

        _flipCancellation?.Cancel();
        _flipCancellation?.Dispose();
        _flipCancellation = new CancellationTokenSource();

        _isFlipping = true;

        Task.Run(async () => {
            try {
                while(!_flipCancellation.IsCancellationRequested) {
                    int delaySeconds;

                    if(_isFlipped) {
                        delaySeconds = FlipIntervalSeconds;
                    }
                    else {
                        delaySeconds = BackSideDurationSeconds;
                    }

                    await Task.Delay(TimeSpan.FromSeconds(delaySeconds), _flipCancellation.Token);
                    await MainThread.InvokeOnMainThreadAsync(FlipTileAsync);
                }
            } catch(TaskCanceledException) {
                // Expected when stopping
            }
            _isFlipping = false;
        }, _flipCancellation.Token);
    }

    private async Task FlipTileAsync() {
        {
            if(_isAnimating || TileSize == TileSizes.Small) {
                return;
            }

            try {
                _isAnimating = true;
                await FlipContainer.RotateXTo(90, 160, Easing.SinInOut);
                _isFlipped = !_isFlipped;
                FrontSide.IsVisible = !_isFlipped;
                BackSide.IsVisible = _isFlipped;
                await FlipContainer.RotateXTo(0, 160, Easing.SinInOut);
            } finally {
                _isAnimating = false;
            }
        }
    }

    public Command UpdateTileSizeCommand => new(async () => {
        var options = new Dictionary<string, TileSizes>
        {
            { "Small", TileSizes.Small },
            { "Medium", TileSizes.Medium },
            { "Wide", TileSizes.Wide },
            { "Large", TileSizes.Large }
        };

        string action = await Shell.Current.DisplayActionSheet("Choose Tile Size", null, null, options.Keys.ToArray());

        if(action != null && options.TryGetValue(action, out TileSizes newSize)) {
            UpdateSize(newSize);
            TileSize = newSize;
            Preferences.Set(nameof(TileSize), newSize.ToString());
        }
    });

    private TileSizes GetSavedTileSize() {

        string savedSize = Preferences.Get(nameof(TileSize), TileSizes.Medium.ToString());

        if(Enum.TryParse(savedSize, out TileSizes tileSize)) {
            return tileSize;
        }

        return TileSizes.Medium;
    }

    protected override void OnParentSet() {
        base.OnParentSet();

        if(Parent == null) {
            _flipCancellation?.Cancel();
            _flipCancellation?.Dispose();
            Loaded -= OnTileLoaded;
            _isFlipping = false;
        }
        else if(!_isFlipping) {
            StartFlipLoop();
        }
    }
}

