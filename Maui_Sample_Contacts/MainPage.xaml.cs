namespace Maui_Sample_Contacts;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
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

    private async void SelectContactButton_Clicked(object sender, EventArgs e)
    {
        try
        {
            /* 자습서 링크 https://learn.microsoft.com/ko-kr/dotnet/maui/platform-integration/device-media/picker?view=net-maui-7.0&tabs=android
             * 자습서에서는 아래와 같이 사용하고 있지만, 현재는 아래와 같이 사용해야 함. 이유는 모르겠음.
             * var contact = await Contacts.Default.PickContactAsync(); 
             */
            var contact = await Contacts.PickContactAsync();

            if (contact == null)
                return;

            string id = contact.Id;
            string namePrefix = contact.NamePrefix;
            string givenName = contact.GivenName;
            string middleName = contact.MiddleName;
            string familyName = contact.FamilyName;
            string nameSuffix = contact.NameSuffix;
            string displayName = contact.DisplayName;
            List<ContactPhone> phones = contact.Phones; // List of phone numbers
            List<ContactEmail> emails = contact.Emails; // List of email addresses
        }
        catch (Exception ex)
        {
            // Most likely permission denied
        }
    }
}

