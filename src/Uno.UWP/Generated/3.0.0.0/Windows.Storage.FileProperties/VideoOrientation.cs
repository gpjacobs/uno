#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Storage.FileProperties
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum VideoOrientation 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Normal,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Rotate90,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Rotate180,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Rotate270,
		#endif
	}
	#endif
}
