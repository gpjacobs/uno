#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Core
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum AudioDecoderDegradation 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		None,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		DownmixTo2Channels,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		DownmixTo6Channels,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		DownmixTo8Channels,
		#endif
	}
	#endif
}
