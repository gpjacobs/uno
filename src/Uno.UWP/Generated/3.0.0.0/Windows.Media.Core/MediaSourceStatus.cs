#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Core
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum MediaSourceStatus 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		FullySupported,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Unknown,
		#endif
	}
	#endif
}
