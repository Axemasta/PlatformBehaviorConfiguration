using PlatformBehaviorConfiguration.Behaviors;

namespace PlatformBehaviorConfiguration
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            Box.On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().SetAlwaysGreen(true);
            Box.On<Microsoft.Maui.Controls.PlatformConfiguration.iOS>().SetAlwaysYellow(true);
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
