#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Input
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	public delegate void RightTappedEventHandler(object @sender, global::Windows.UI.Xaml.Input.RightTappedRoutedEventArgs @e);
	#endif
}
