# MS자습서 따라하기

첫번째 연락처 가져오기
https://learn.microsoft.com/ko-kr/dotnet/maui/platform-integration/communication/contacts?view=net-maui-7.0&tabs=android
 * 자습서에서 안내된 부분 중 
 private async void SelectContactButton_Clicked(object sender, EventArgs e)
{
    (생략) 이부분에서 에러가 나서 결국.. 수정함..
    var contact = await Contacts.Default.PickContactAsync();  ---->>>   var contact = await Contacts.PickContactAsync();
    (생략)
}
