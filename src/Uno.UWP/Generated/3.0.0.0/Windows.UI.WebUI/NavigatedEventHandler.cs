#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.WebUI
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	public delegate void NavigatedEventHandler(object @sender, global::Windows.UI.WebUI.IWebUINavigatedEventArgs @e);
	#endif
}
