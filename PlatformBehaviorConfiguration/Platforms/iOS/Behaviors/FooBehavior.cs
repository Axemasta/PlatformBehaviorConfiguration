using Microsoft.Maui.Platform;
using UIKit;

namespace PlatformBehaviorConfiguration.Behaviors;

public partial class FooBehavior
{
    protected override void OnAttachedTo(View bindable, UIView platformView)
    {
        base.OnAttachedTo(bindable, platformView);


        if (TintColor is not null)
        {
            if (iOSConfiguration.GetAlwaysYellow(bindable))
            {
                platformView.BackgroundColor = UIColor.Yellow;

            }
            else
            {
                platformView.BackgroundColor = TintColor.ToPlatform();
            }
        }
    }
}