#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System.Profile
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum PlatformDataCollectionLevel 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Security,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Basic,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Enhanced,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Full,
		#endif
	}
	#endif
}
