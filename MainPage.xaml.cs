using static TestXamlBindings.MainPage;

namespace TestXamlBindings;

public partial class MainPage : ContentPage
{
	int count = 0;

    private Dictionary<UserSetting, object> _userSettings;

    public Dictionary<UserSetting, object> UserSettings
    {
        get { return _userSettings; }
        set
        {
            _userSettings = value;
        }
    }

    public MainPage()
	{
        UserSettings = new Dictionary<UserSetting, object>
        {
            { UserSetting.TBD, "pups" }
        };

        InitializeComponent();
        
        BindingContext = this;
        
    }

    public enum UserSetting
    {
        BrowserInvisible,
        GlobalWaitForElementsInBrowserInSek,
        TBD,

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

