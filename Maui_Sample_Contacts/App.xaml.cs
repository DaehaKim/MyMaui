using System.Diagnostics;

namespace Maui_Sample_Contacts;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new MainPage();
    }
    protected override Window CreateWindow(IActivationState activationState)
    {
        Window window = base.CreateWindow(activationState);
        window.Created += (s, e) => { Debug.WriteLine("******** Created ********"); };
        window.Activated += (s, e) => { Debug.WriteLine("******** Activated ********"); };
        window.Deactivated += (s, e) => { Debug.WriteLine("******** Deactivated ********"); };
        window.Stopped += (s, e) => { Debug.WriteLine("******** Stopped ********"); };
        window.Resumed += (s, e) => { Debug.WriteLine("******** Resumed ********"); };
        window.Destroying += (s, e) => { Debug.WriteLine("******** Destroying ********"); };
        return window;
    }

    protected override void OnStart()
    {
        Debug.WriteLine("******** OnStart ********");
    }

    protected override void OnSleep()
    {
        Debug.WriteLine("******** OnSleep ********");
    }

    protected override void OnResume()
    {
        Debug.WriteLine("******** OnResume ********");
    }
}
