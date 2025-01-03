
using Android.Graphics.Drawables;
using AndroidX.Core.Graphics.Drawable;
using Microsoft.Maui.Graphics.Platform;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;
using AView = Android.Views.View;

namespace PlatformBehaviorConfiguration.Behaviors;

public partial class FooBehavior
{
    protected override void OnAttachedTo(Microsoft.Maui.Controls.View bindable, Android.Views.View platformView)
    {
        base.OnAttachedTo(bindable, platformView);

        if (TintColor is not null)
        {
            if (AndroidConfiguration.GetAlwaysGreen(bindable))
            {
                platformView.SetBackgroundColor(Android.Graphics.Color.Green);
            }
            else
            {
                platformView.SetBackgroundColor(TintColor.ToPlatform());
            }
        }
    }
}

