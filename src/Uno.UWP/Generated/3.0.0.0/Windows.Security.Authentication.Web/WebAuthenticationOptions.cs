#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Security.Authentication.Web
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum WebAuthenticationOptions 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		None,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		SilentMode,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		UseTitle,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		UseHttpPost,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		UseCorporateNetwork,
		#endif
	}
	#endif
}
