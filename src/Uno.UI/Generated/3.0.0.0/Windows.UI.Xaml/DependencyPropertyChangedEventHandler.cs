#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	public delegate void DependencyPropertyChangedEventHandler(object @sender, global::Windows.UI.Xaml.DependencyPropertyChangedEventArgs @e);
	#endif
}
