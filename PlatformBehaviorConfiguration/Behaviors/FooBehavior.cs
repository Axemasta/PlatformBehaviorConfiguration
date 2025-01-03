namespace PlatformBehaviorConfiguration.Behaviors;

public partial class FooBehavior : PlatformBehavior<View>
{
    /// <summary>
	/// Attached Bindable Property for the <see cref="TintColor"/>.
	/// </summary>
	public static readonly BindableProperty TintColorProperty =
        BindableProperty.Create(nameof(TintColor), typeof(Color), typeof(FooBehavior), default);

    /// <summary>
    /// Property that represents the <see cref="Color"/> that Icon will be tinted.
    /// </summary>
    public Color? TintColor
    {
        get => (Color?)GetValue(TintColorProperty);
        set => SetValue(TintColorProperty, value);
    }
}

public static class AndroidConfiguration
{
    public static readonly BindableProperty AlwaysGreenProperty = BindableProperty.Create("AlwaysGreen", typeof(bool), typeof(AndroidConfiguration), false);

    public static IPlatformElementConfiguration<Microsoft.Maui.Controls.PlatformConfiguration.Android, View> SetAlwaysGreen(this IPlatformElementConfiguration<Microsoft.Maui.Controls.PlatformConfiguration.Android, View> config, bool value)
    {
        SetAlwaysGreen(config.Element, value);
        return config;
    }

    public static void SetAlwaysGreen(BindableObject element, bool value)
    {
        element.SetValue(AlwaysGreenProperty, value);
    }

    public static bool GetAlwaysGreen(BindableObject element)
    {
        return (bool)element.GetValue(AlwaysGreenProperty);
    }
}

public static class iOSConfiguration
{
    public static readonly BindableProperty AlwaysYellowProperty = BindableProperty.Create("AlwaysYellow", typeof(bool), typeof(iOSConfiguration), false);

    public static IPlatformElementConfiguration<Microsoft.Maui.Controls.PlatformConfiguration.iOS, View> SetAlwaysYellow(this IPlatformElementConfiguration<Microsoft.Maui.Controls.PlatformConfiguration.iOS, View> config, bool value)
    {
        SetAlwaysYellow(config.Element, value);
        return config;
    }

    public static void SetAlwaysYellow(BindableObject element, bool value)
    {
        element.SetValue(AlwaysYellowProperty, value);
    }

    public static bool GetAlwaysYellow(BindableObject element)
    {
        return (bool)element.GetValue(AlwaysYellowProperty);
    }
}