#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum HandwritingPanelPlacementAlignment 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Auto,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		TopLeft,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		TopRight,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		BottomLeft,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		BottomRight,
		#endif
	}
	#endif
}
