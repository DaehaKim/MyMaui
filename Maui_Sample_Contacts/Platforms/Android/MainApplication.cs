using Android.App;
using Android.Runtime;
[assembly: UsesPermission(Android.Manifest.Permission.ReadContacts)]

namespace Maui_Sample_Contacts;

[Application]
public class MainApplication : MauiApplication
{
	public MainApplication(IntPtr handle, JniHandleOwnership ownership)
		: base(handle, ownership)
	{
	}

	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}
