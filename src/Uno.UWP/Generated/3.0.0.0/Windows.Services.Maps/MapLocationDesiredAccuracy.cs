#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Services.Maps
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum MapLocationDesiredAccuracy 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		High,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Low,
		#endif
	}
	#endif
}
