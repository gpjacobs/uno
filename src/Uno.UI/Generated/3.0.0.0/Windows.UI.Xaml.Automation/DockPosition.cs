#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Automation
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum DockPosition 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Top,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Left,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Bottom,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Right,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Fill,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		None,
		#endif
	}
	#endif
}
