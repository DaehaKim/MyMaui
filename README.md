# 1. MS자습서 따라하기

## 첫번째 연락처 가져오기  : https://learn.microsoft.com/ko-kr/dotnet/maui/platform-integration/communication/contacts?view=net-maui-7.0&tabs=android

* 자습서에서 안내된 부분 중 
```c#
private async void SelectContactButton_Clicked(object sender, EventArgs e)
{
    //(생략) 이부분에서 에러가 나서 결국.. 수정함..
    var contact = await Contacts.Default.PickContactAsync();  ---->>>   var contact = await Contacts.PickContactAsync();
    //(생략)
}
```
---
# 2. FontAwesome 추가

## Font 다운로드  : https://github.com/FortAwesome/Font-Awesome/tree/6.x/webfonts
  * 다음 폴더에 추가 : Resources\Fonts\
## IconFont2Code 사이트 https://github.com/andreinitescu/IconFont2Code
  * How to use IconFont2Code 보고 따라하기
  * 출력된 내용을 복사해서 다음 폴더에 파일 만들어 추가 : Resources\Styles
## MauiProgram.cs 빌더에 폰트 추
```c#
public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("fa-regular-400.ttf", "FontAwesomeRegular");
				fonts.AddFont("fa-solid-900.ttf", "FontAwesomeSolid");
				fonts.AddFont("fa-brands-400.ttf", "FontAwesomeBrands");
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
```
## MainPage에 추가
```XAML
xmlns:fa="clr-namespace:PassXYZ.Vault.Resources.Styles"
```
```XAML
<Button>
  <Button.ImageSource>
    <FontImageSource FontFamily="FontAwesomeSolid"
                     Glyph="{x:Static fa:FontAwesomeSolid.CirclePlus}"
                     Color="{DynamicResource Yellow200Accent}"
                     Size="16"/>
  </Button.ImageSource>
</Button>
```
