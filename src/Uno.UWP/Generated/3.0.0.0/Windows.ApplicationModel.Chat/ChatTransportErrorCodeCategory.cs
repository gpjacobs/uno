#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Chat
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum ChatTransportErrorCodeCategory 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		None,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Http,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Network,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		MmsServer,
		#endif
	}
	#endif
}
